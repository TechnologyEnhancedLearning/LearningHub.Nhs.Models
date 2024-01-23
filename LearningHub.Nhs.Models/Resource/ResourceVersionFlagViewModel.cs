// <copyright file="ResourceVersionFlagViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The resource version flag view model.
    /// </summary>
    public class ResourceVersionFlagViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the flagged by user id.
        /// </summary>
        public int FlaggedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the flagged by.
        /// </summary>
        public string FlaggedByName { get; set; }

        /// <summary>
        /// Gets or sets the resolution.
        /// </summary>
        public string Resolution { get; set; }
    }
}
