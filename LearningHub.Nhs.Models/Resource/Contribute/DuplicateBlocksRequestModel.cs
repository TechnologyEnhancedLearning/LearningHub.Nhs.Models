// <copyright file="DuplicateBlocksRequestModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Contribute
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The duplicate blocks request model.
    /// </summary>
    public class DuplicateBlocksRequestModel
    {
        /// <summary>
        /// Gets or sets the source resource id.
        /// </summary>
        public int SourceResourceId { get; set; }

        /// <summary>
        /// Gets or sets the block ids.
        /// </summary>
        public IEnumerable<int> BlockIds { get; set; }

        /// <summary>
        /// Gets or sets the destination resource id.
        /// </summary>
        public int? DestinationResourceId { get; set; }

        /// <summary>
        /// Gets or sets the assessment type.
        /// </summary>
        public AssessmentTypeEnum? AssessmentType { get; set; }
    }
}
