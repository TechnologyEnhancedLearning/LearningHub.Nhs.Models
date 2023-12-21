// <copyright file="UserSecurityQuestionViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The user security question view model.
    /// </summary>
    public class UserSecurityQuestionViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the security question id.
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "Select a question.")]
        public int SecurityQuestionId { get; set; }

        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        public string QuestionText { get; set; }

        /// <summary>
        /// Gets or sets the security question answer hash.
        /// </summary>
        [Required(ErrorMessage = "Enter an answer.")]
        public string SecurityQuestionAnswerHash { get; set; }
    }
}
