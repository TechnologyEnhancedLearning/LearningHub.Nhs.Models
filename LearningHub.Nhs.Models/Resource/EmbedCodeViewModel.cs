// <copyright file="EmbedCodeViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The embed code view model.
    /// </summary>
    public class EmbedCodeViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the embed code.
        /// </summary>
        public string EmbedCode { get; set; }
    }
}
