namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The scorm activity interaction.
    /// </summary>
    public partial class ScormActivityInteraction : EntityBase
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="ScormActivityInteraction"/> class.
        /// </summary>
        public ScormActivityInteraction()
        {
            this.ScormActivityInteractionCorrectResponse = new HashSet<ScormActivityInteractionCorrectResponse>();
            this.ScormActivityInteractionObjective = new HashSet<ScormActivityInteractionObjective>();
        }

        /// <summary>
        /// Gets or sets the scorm activity id.
        /// </summary>
        public int ScormActivityId { get; set; }

        /// <summary>
        /// Gets or sets the interaction id.
        /// </summary>
        public string InteractionId { get; set; }

        /// <summary>
        /// Gets or sets the Sequence Number.
        /// </summary>
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the weighting.
        /// </summary>
        public decimal? Weighting { get; set; }

        /// <summary>
        /// Gets or sets the student response.
        /// </summary>
        public string StudentResponse { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets the latency.
        /// </summary>
        public string Latency { get; set; }

        /// <summary>
        /// Gets or sets the scorm activity.
        /// </summary>
        public virtual ScormActivity ScormActivity { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivity Interaction CorrectResponses.
        /// </summary>
        public virtual ICollection<ScormActivityInteractionCorrectResponse> ScormActivityInteractionCorrectResponse { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivity Interaction Objectives.
        /// </summary>
        public virtual ICollection<ScormActivityInteractionObjective> ScormActivityInteractionObjective { get; set; }
    }
}
