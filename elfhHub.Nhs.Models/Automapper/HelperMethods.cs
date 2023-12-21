// <copyright file="HelperMethods.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Automapper
{
    /// <summary>
    /// The elfh mapping helpers.
    /// </summary>
    internal static class HelperMethods
    {
        /// <summary>
        /// Prefix value with a comma if it exists.
        /// </summary>
        /// <param name="value">Input string.</param>
        /// <returns>Prefixed output.</returns>
        public static string AddPrefix(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {
                return ", " + value;
            }
        }
    }
}
