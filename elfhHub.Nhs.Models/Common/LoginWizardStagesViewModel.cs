namespace elfhHub.Nhs.Models.Common
{
    using System.Collections.Generic;
    using elfhHub.Nhs.Models.Entities;

    /// <summary>
    /// The login wizard stages view model.
    /// </summary>
    public class LoginWizardStagesViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether is first login.
        /// </summary>
        public bool IsFirstLogin { get; set; }

        /// <summary>
        /// Gets or sets the login wizard stages.
        /// </summary>
        public List<LoginWizardStage> LoginWizardStages { get; set; }

        /// <summary>
        /// Gets or sets the login wizard stages completed.
        /// </summary>
        public List<LoginWizardStage> LoginWizardStagesCompleted { get; set; }
    }
}
