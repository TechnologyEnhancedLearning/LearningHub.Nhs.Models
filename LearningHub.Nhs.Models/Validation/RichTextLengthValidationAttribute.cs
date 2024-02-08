namespace LearningHub.Nhs.Models.Validation
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Web;
    using HtmlAgilityPack;

    /// <summary>
    /// The rich text file length validator.
    /// </summary>
    public class RichTextLengthValidationAttribute : ValidationAttribute
    {
        private readonly int maxLength;

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextLengthValidationAttribute"/> class.
        /// </summary>
        /// <param name="maxLength">The max length.</param>
        public RichTextLengthValidationAttribute(int maxLength)
        {
            this.maxLength = maxLength;
        }

        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        /// <param name="value">The value of the object to validate.</param>
        /// <returns>true if the specified value is valid; otherwise, false.</returns>
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            var document = new HtmlDocument();
            document.LoadHtml((string)value);

            if (document.ParseErrors.Any())
            {
                return false;
            }
            else
            {
                var text = document.DocumentNode.InnerText;
                text = HttpUtility.HtmlDecode(text).Replace("\r", string.Empty);
                text = Regex.Replace(text, @"\s\n\n", " ", RegexOptions.Multiline);
                text = Regex.Replace(text, @"\n\n", " ", RegexOptions.Multiline);
                text = Regex.Replace(text, @"\s\n", string.Empty, RegexOptions.Multiline);
                text = Regex.Replace(text, @"\n", string.Empty, RegexOptions.Multiline);
                if (this.maxLength < text.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
