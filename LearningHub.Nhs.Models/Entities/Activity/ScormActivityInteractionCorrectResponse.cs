// <copyright file="ScormActivityInteractionCorrectResponse.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Activity
{
    /// <summary>
    /// The ScormActivity Interaction CorrectResponse.
    /// </summary>
    public partial class ScormActivityInteractionCorrectResponse : EntityBase
    {
        /// <summary>
        /// Gets or sets the ScormActivityInteractionId.
        /// </summary>
        public int ScormActivityInteractionId { get; set; }

        /// <summary>
        /// Gets or sets the Index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the Pattern.
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivityInteraction.
        /// </summary>
        public virtual ScormActivityInteraction ScormActivityInteraction { get; set; }
    }
}
