// <copyright file="LoginWizardStageActivity.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The login wizard stage activity.
    /// </summary>
    public class LoginWizardStageActivity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginWizardStageActivity"/> class.
        /// </summary>
        public LoginWizardStageActivity()
        {
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the login wizard stage id.
        /// </summary>
        public int LoginWizardStageId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the activity datetime.
        /// </summary>
        public DateTimeOffset ActivityDatetime { get; set; }

        /// <summary>
        /// Gets or sets the login wizard stage.
        /// </summary>
        public virtual LoginWizardStage LoginWizardStage { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }
    }
}
