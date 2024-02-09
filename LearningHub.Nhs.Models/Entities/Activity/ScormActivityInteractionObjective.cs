namespace LearningHub.Nhs.Models.Entities.Activity
{
    /// <summary>
    /// ScormActivity Interaction Objective.
    /// </summary>
    public partial class ScormActivityInteractionObjective : EntityBase
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
        /// Gets or sets the ObjectiveId.
        /// </summary>
        public string ObjectiveId { get; set; }

        /// <summary>
        /// Gets or sets the ScormActivityInteraction.
        /// </summary>
        public virtual ScormActivityInteraction ScormActivityInteraction { get; set; }
    }
}
