// <copyright file="CreateMediaResourceActivityViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System;

    /// <summary>
    /// The create media resource activity view model.
    /// </summary>
    public class CreateMediaResourceActivityViewModel
    {
        /// <summary>
        /// Gets or sets the resource activity id.
        /// </summary>
        public int ResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the activity start date time.
        /// </summary>
        public DateTimeOffset ActivityStart { get; set; }
    }
}
