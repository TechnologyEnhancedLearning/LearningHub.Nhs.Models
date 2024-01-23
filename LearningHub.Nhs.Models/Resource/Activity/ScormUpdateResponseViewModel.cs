// <copyright file="ScormUpdateResponseViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The update scorm response view model.
    /// </summary>
    public class ScormUpdateResponseViewModel
    {
        /// <summary>
        /// Gets or sets the instance id (resoure activity id).
        /// </summary>
        public int InstanceId { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivityInteractions.
        /// </summary>
        public ICollection<ScormUpdateInteractionViewModel> ScormActivityInteraction { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivityObjectives.
        /// </summary>
        public ICollection<ScormUpdateObjectiveViewModel> ScormActivityObjective { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether object is valid.
        /// </summary>
        public bool IsValid { get; set; }
    }
}
