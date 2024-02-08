namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The scorm activity.
    /// </summary>
    public partial class ScormActivity : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScormActivity"/> class.
        /// The scorm activity.
        /// </summary>
        public ScormActivity()
        {
            this.ScormActivityInteraction = new HashSet<ScormActivityInteraction>();
            this.ScormActivityObjective = new HashSet<ScormActivityObjective>();
        }

        /// <summary>
        /// Gets or sets the resource activity id.
        /// </summary>
        public int? ResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.Core.LessonLocation.
        /// </summary>
        public string CmiCoreLessonLocation { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.Core.LessonStatus.
        /// </summary>
        public int? CmiCoreLessonStatus { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.Core.ScoreRaw.
        /// </summary>
        public decimal? CmiCoreScoreRaw { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.Core.ScoreMin.
        /// </summary>
        public decimal? CmiCoreScoreMin { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.Core.ScoreMax.
        /// </summary>
        public decimal? CmiCoreScoreMax { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.Core.Exit.
        /// </summary>
        public string CmiCoreExit { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.Core.SessionTime.
        /// </summary>
        public string CmiCoreSessionTime { get; set; }

        /// <summary>
        /// Gets or sets the Cmi.SuspendData.
        /// </summary>
        public string CmiSuspendData { get; set; }

        /// <summary>
        /// Gets or sets the DurationSeconds.
        /// </summary>
        public int DurationSeconds { get; set; }

        /// <summary>
        /// Gets or sets the ResourceActivity.
        /// </summary>
        public virtual ResourceActivity ResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivityInteraction.
        /// </summary>
        public virtual ICollection<ScormActivityInteraction> ScormActivityInteraction { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivityObjective.
        /// </summary>
        public virtual ICollection<ScormActivityObjective> ScormActivityObjective { get; set; }
    }
}
