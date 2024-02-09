namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The update scorm activity view model.
    /// </summary>
    public class ScormActivityInteractionViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScormActivityInteractionViewModel"/> class.
        /// </summary>
        public ScormActivityInteractionViewModel()
        {
            this.ScormActivityInteractionCorrectResponse = new List<ScormActivityInteractionCorrectResponseViewModel>();
            this.ScormActivityInteractionObjective = new List<ScormActivityInteractionObjectiveViewModel>();
        }

        /// <summary>
        /// Gets or sets the scorm activity interaction id.
        /// </summary>
        public int ScormActivityInteractionId { get; set; }

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
        /// Gets or sets ScormActivity Interaction CorrectResponse.
        /// </summary>
        public ICollection<ScormActivityInteractionCorrectResponseViewModel> ScormActivityInteractionCorrectResponse { get; set; }

        /// <summary>
        /// Gets or sets ScormActivity Interaction Objective.
        /// </summary>
        public ICollection<ScormActivityInteractionObjectiveViewModel> ScormActivityInteractionObjective { get; set; }
    }
}
