namespace LearningHub.Nhs.Models.RoadMap
{
    using System;

    /// <summary>
    /// Defines the <see cref="RoadMapViewModel" />.
    /// </summary>
    public class RoadMapViewModel
    {
        /// <summary>
        /// Gets or sets the roadmap type id..
        /// </summary>
        public int RoadmapTypeId { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the roadmap date..
        /// </summary>
        public DateTimeOffset? RoadmapDate { get; set; }

        /// <summary>
        /// Gets or sets the image name..
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the order number..
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the roadmap is published..
        /// </summary>
        public bool Published { get; set; }
    }
}
