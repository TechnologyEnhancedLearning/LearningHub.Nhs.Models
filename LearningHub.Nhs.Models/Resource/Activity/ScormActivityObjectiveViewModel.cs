namespace LearningHub.Nhs.Models.Resource.Activity
{
    /// <summary>
    /// The update scorm activity view model.
    /// </summary>
    public class ScormActivityObjectiveViewModel
    {
        /// <summary>
        /// Gets or sets the scorm activity objective id.
        /// </summary>
        public int ScormActivityObjectiveId { get; set; }

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
    }
}
