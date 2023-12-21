// <copyright file="LoginWizardStage.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The login wizard stage.
    /// </summary>
    public class LoginWizardStage : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginWizardStage"/> class.
        /// </summary>
        public LoginWizardStage()
        {
            this.LoginWizardRules = new HashSet<LoginWizardRule>();
            this.LoginWizardStageActivity = new HashSet<LoginWizardStageActivity>();
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the reason display text.
        /// </summary>
        public string ReasonDisplayText { get; set; }

        /// <summary>
        /// Gets or sets the login wizard rules.
        /// </summary>
        public virtual ICollection<LoginWizardRule> LoginWizardRules { get; set; }

        /// <summary>
        /// Gets or sets the login wizard stage activity.
        /// </summary>
        public virtual ICollection<LoginWizardStageActivity> LoginWizardStageActivity { get; set; }
    }
}
