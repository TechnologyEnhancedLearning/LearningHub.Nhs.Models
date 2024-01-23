// <copyright file="ErrorResponse.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Common
{
    /// <summary>
    /// The error response.
    /// </summary>
    public class ErrorResponse : ApiResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse"/> class.
        /// </summary>
        /// <param name="errorMessage">
        /// The error message.
        /// </param>
        /// <param name="errorDescription">
        /// The error description.
        /// </param>
        public ErrorResponse(string errorMessage, string errorDescription)
            : base(false)
        {
            this.ErrorMessage = errorMessage;
            this.ErrorDescription = errorDescription;
        }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the error description.
        /// </summary>
        public string ErrorDescription { get; set; }
    }
}
