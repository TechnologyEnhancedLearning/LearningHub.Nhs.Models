// <copyright file="SendEmailModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Email
{
    /// <summary>
    /// The SendEmailModel.
    /// </summary>
    /// <typeparam name="T">The email model.</typeparam>
    public class SendEmailModel<T>
        where T : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailModel{T}"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public SendEmailModel(T model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets the email model.
        /// </summary>
        public T Model { get; private set; }
    }
}
