// <copyright file="SanitizeHtmlUtility.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Binders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;
    using HtmlAgilityPack;

    /// <summary>
    /// The Sanitize Html Utility.
    /// </summary>
    public class SanitizeHtmlUtility
    {
        /// <summary>
        /// Html Sanitizer.
        /// </summary>
        /// <param name="data">Html string.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Sanitize(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            var document = new HtmlDocument();
            document.LoadHtml(data);

            if (document.ParseErrors.Any())
            {
                throw new Exception("Invalid html.");
            }

            var insecureTags = new[] { "script", "frameset", "frame", "iframe", "object", "embed", "xss" };

            var nodes = new Queue<HtmlNode>(document.DocumentNode.SelectNodes("./*|./text()"));
            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                var parentNode = node.ParentNode;

                if (insecureTags.Contains(RemoveNullCharacter(node.Name))
                    || (node.Name == "style" && ContainsScript(node.InnerText.Replace("\\", string.Empty))))
                {
                    parentNode.RemoveChild(node);
                }
                else
                {
                    foreach (var attribute in node.Attributes.ToList())
                    {
                        if (attribute.Name.StartsWith("on") || ContainsScript(attribute.Value))
                        {
                            attribute.Remove();
                        }
                    }

                    var childNodes = node.SelectNodes("./*|./text()");
                    if (childNodes != null)
                    {
                        foreach (var child in childNodes)
                        {
                            nodes.Enqueue(child);
                        }
                    }
                }
            }

            return document.DocumentNode.InnerHtml;
        }

        private static bool ContainsScript(string value)
        {
            value = RemoveNullCharacter(value);

            return ContainsClientExecutable(WebUtility.HtmlDecode(value))
                    || ContainsClientExecutable(WebUtility.UrlDecode(value))
                    || ContainsClientExecutable(HtmlDecodeForBrowserAutoCorrection(value));
        }

        private static bool ContainsClientExecutable(string value)
        {
            var withoutWhitepace = Regex.Replace(value, @"\s+", string.Empty).ToLower();
            return withoutWhitepace.Contains("javascript:") || withoutWhitepace.Contains("expression(");
        }

        private static string HtmlDecodeForBrowserAutoCorrection(string value)
        {
            return WebUtility.HtmlDecode(value.Replace("&#", ";&#"));
        }

        private static string RemoveNullCharacter(string value)
        {
            return value.Replace("%00", string.Empty).Replace("\\0", string.Empty);
        }
    }
}
