namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The AssessmentResourceActivity.
    /// </summary>
    public partial class AssessmentResourceActivity : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentResourceActivity"/> class.
        /// </summary>
        public AssessmentResourceActivity()
        {
            this.AssessmentResourceActivityInteractions = new HashSet<AssessmentResourceActivityInteraction>();
            this.MatchQuestions = new HashSet<AssessmentResourceActivityMatchQuestion>();
        }

        /// <summary>
        /// Gets or sets the ResourceActivityId.
        /// </summary>
        public int ResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the Score.
        /// </summary>
        public decimal? Score { get; set; }

        /// <summary>
        /// Gets or sets the Reason.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the ResourceActivity.
        /// </summary>
        public virtual ResourceActivity ResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the AssessmentResourceActivityInteraction.
        /// </summary>
        public virtual ICollection<AssessmentResourceActivityInteraction> AssessmentResourceActivityInteractions { get; set; }

        /// <summary>
        /// Gets or sets the state of the match questions.
        /// </summary>
        public virtual ICollection<AssessmentResourceActivityMatchQuestion> MatchQuestions { get; set; }
    }
}