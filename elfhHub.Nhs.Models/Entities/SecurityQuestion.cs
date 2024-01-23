// <copyright file="SecurityQuestion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The security question.
    /// </summary>
    public class SecurityQuestion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityQuestion"/> class.
        /// </summary>
        public SecurityQuestion()
        {
            this.UserSecurityQuestion = new HashSet<UserSecurityQuestion>();
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the user security question.
        /// </summary>
        public virtual ICollection<UserSecurityQuestion> UserSecurityQuestion { get; set; }
    }
}
