namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The update scorm activity view model.
    /// </summary>
    public class ScormActivityViewModel
    {
        /// <summary>
        /// Gets or sets the cloned from ScormActivityId.
        /// </summary>
        public int? ClonedFromScormActivityId { get; set; }

        /// <summary>
        /// Gets or sets the instance id (resoure activity id).
        /// </summary>
        public int InstanceId { get; set; }

        /// <summary>
        /// Gets or sets the Lesson Location.
        /// </summary>
        public string LessonLocation { get; set; }

        /// <summary>
        /// Gets or sets the Lesson Status id.
        /// </summary>
        public int? LessonStatusId { get; set; }

        /// <summary>
        /// Gets or sets the Score Raw.
        /// </summary>
        public decimal? ScoreRaw { get; set; }

        /// <summary>
        /// Gets or sets the Score Min.
        /// </summary>
        public decimal? ScoreMin { get; set; }

        /// <summary>
        /// Gets or sets the Score Max.
        /// </summary>
        public decimal? ScoreMax { get; set; }

        /// <summary>
        /// Gets or sets the Exit.
        /// </summary>
        public string Exit { get; set; }

        /// <summary>
        /// Gets or sets the Session Time.
        /// </summary>
        public string SessionTime { get; set; }

        /// <summary>
        /// Gets or sets the Total Session Time.
        /// </summary>
        public string TotalTime { get; set; }

        /// <summary>
        /// Gets or sets the Suspend Data.
        /// </summary>
        public string SuspendData { get; set; }

        /// <summary>
        /// Gets or sets the DurationSeconds.
        /// </summary>
        public int DurationSeconds { get; set; }

        /// <summary>
        /// Gets the Interactions Count.
        /// </summary>
        public int InteractionsCount
        {
            get { return this.ScormActivityInteraction != null ? this.ScormActivityInteraction.Count : 0; }
        }

        /// <summary>
        /// Gets the objectives Count.
        /// </summary>
        public int ObjectivesCount
        {
            get { return this.ScormActivityObjective != null ? this.ScormActivityObjective.Count : 0; }
        }

        /// <summary>
        /// Gets or sets the ScormActivityInteractions.
        /// </summary>
        public ICollection<ScormActivityInteractionViewModel> ScormActivityInteraction { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivityObjectives.
        /// </summary>
        public ICollection<ScormActivityObjectiveViewModel> ScormActivityObjective { get; set; }
    }
}
