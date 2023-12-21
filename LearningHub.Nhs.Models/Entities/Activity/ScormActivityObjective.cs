// <copyright file="ScormActivityObjective.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Activity
{
    /// <summary>
    /// The scorm activity objective.
    /// </summary>
    public partial class ScormActivityObjective : EntityBase
    {
        /// <summary>
        /// Gets or sets the scorm activity id.
        /// </summary>
        public int ScormActivityId { get; set; }

        /// <summary>
        /// Gets or sets the objective id.
        /// </summary>
        public string ObjectiveId { get; set; }

        /// <summary>
        /// Gets or sets the Sequence Number.
        /// </summary>
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the scoreRaw.
        /// </summary>
        public string ScoreRaw { get; set; }

        /// <summary>
        /// Gets or sets the scoreMax.
        /// </summary>
        public string ScoreMax { get; set; }

        /// <summary>
        /// Gets or sets the scoreMin.
        /// </summary>
        public string ScoreMin { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the scorm activity.
        /// </summary>
        public virtual ScormActivity ScormActivity { get; set; }
    }
}