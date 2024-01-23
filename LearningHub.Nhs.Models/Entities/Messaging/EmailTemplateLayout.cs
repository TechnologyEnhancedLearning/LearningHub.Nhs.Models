// <copyright file="EmailTemplateLayout.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Messaging
{
    /// <summary>
    /// The email template type.
    /// </summary>
    public class EmailTemplateLayout : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the available tags.
        /// </summary>
        public string Body { get; set; }
    }
}
