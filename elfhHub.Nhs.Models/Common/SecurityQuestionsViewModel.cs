// <copyright file="SecurityQuestionsViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.Rendering;

    /// <summary>
    /// The security questions view model.
    /// </summary>
    public class SecurityQuestionsViewModel
    {
        /// <summary>
        /// Gets or sets the security questions.
        /// </summary>
        public List<SelectListItem> SecurityQuestions { get; set; }

        /// <summary>
        /// Gets or sets the user security questions.
        /// </summary>
        public List<UserSecurityQuestionViewModel> UserSecurityQuestions { get; set; }
    }
}
