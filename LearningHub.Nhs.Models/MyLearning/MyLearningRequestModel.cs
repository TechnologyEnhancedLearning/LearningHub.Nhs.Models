// <copyright file="MyLearningRequestModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.MyLearning
{
    using System;

    /// <summary>
    /// The My Learning request model.
    /// </summary>
    public class MyLearningRequestModel
    {
        /// <summary>
        /// Gets or sets the text string to search for.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for weblink resources.
        /// </summary>
        public bool Weblink { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for file resources.
        /// </summary>
        public bool File { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for video resources.
        /// </summary>
        public bool Video { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for article resources.
        /// </summary>
        public bool Article { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for case resources.
        /// </summary>
        public bool Case { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for image resources.
        /// </summary>
        public bool Image { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for audio resources.
        /// </summary>
        public bool Audio { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for e-learning resources.
        /// </summary>
        public bool Elearning { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity for assessment resources.
        /// </summary>
        public bool Assessment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity with complete status.
        /// </summary>
        public bool Complete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity with incomplete status.
        /// </summary>
        public bool Incomplete { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity with passed status.
        /// </summary>
        public bool Passed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity with failed status.
        /// </summary>
        public bool Failed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include activity with downloaded status.
        /// </summary>
        public bool Downloaded { get; set; }

        /// <summary>
        /// Gets or sets the type of time period to search by.
        /// </summary>
        public string TimePeriod { get; set; }

        /// <summary>
        /// Gets or sets the start date to define on the search.
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date to define on the search.
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether to include activity with certificates.
        /// </summary>
        public bool CertificateEnabled { get; set; }

        /// <summary>
        /// Gets or sets the number of records to skip.
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// Gets or sets the number of records to return.
        /// </summary>
        public int Take { get; set; }
    }
}
