// <copyright file="LoginWizardRule.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The login wizard rule.
    /// </summary>
    public class LoginWizardRule : EntityBase
    {
        /// <summary>
        /// Gets or sets the login wizard stage id.
        /// </summary>
        public int LoginWizardStageId { get; set; }

        /// <summary>
        /// Gets or sets the login wizard rule category id.
        /// </summary>
        public int LoginWizardRuleCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the reason display text.
        /// </summary>
        public string ReasonDisplayText { get; set; }

        /// <summary>
        /// Gets or sets the activation period.
        /// </summary>
        public int? ActivationPeriod { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether required.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the login wizard stage.
        /// </summary>
        public virtual LoginWizardStage LoginWizardStage { get; set; }
    }
}
