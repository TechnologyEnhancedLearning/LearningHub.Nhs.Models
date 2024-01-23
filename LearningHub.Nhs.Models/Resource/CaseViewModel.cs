// <copyright file="CaseViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Resource.Blocks;

    /// <summary>
    /// The web link view model.
    /// </summary>
    public class CaseViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the Block Collection.
        /// </summary>
        public BlockCollectionViewModel BlockCollection { get; set; }
    }
}
