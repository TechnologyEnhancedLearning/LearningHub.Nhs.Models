// <copyright file="LearningHubValidationResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The learning hub validation result.
    /// </summary>
    public class LearningHubValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningHubValidationResult"/> class.
        /// </summary>
        public LearningHubValidationResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningHubValidationResult"/> class.
        /// </summary>
        /// <param name="success">
        /// The success.
        /// </param>
        public LearningHubValidationResult(bool success)
        {
            this.IsValid = success;
            this.Details = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningHubValidationResult"/> class.
        /// </summary>
        /// <param name="success">
        /// The success.
        /// </param>
        /// <param name="detail">
        /// The detail.
        /// </param>
        public LearningHubValidationResult(bool success, string detail)
        {
            this.IsValid = success;
            this.Details = new List<string>();
            this.Details.Add(detail);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningHubValidationResult"/> class.
        /// </summary>
        /// <param name="validationResult">
        /// The validation result.
        /// </param>
        public LearningHubValidationResult(FluentValidation.Results.ValidationResult validationResult)
        {
            this.IsValid = validationResult.IsValid;
            this.Details = validationResult.Errors.Select(vf => vf.ErrorMessage).ToList();
        }

        /// <summary>
        /// Gets or sets a value indicating whether is valid.
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public List<string> Details { get; set; }

        /// <summary>
        /// Gets or sets the created id.
        /// </summary>
        public int? CreatedId { get; set; }

        /// <summary>
        /// Gets or sets the updated ids.
        /// </summary>
        public List<int> UpdatedIds { get; set; }

        #region Operator Overloads

        /// <summary>
        /// The +.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        public static LearningHubValidationResult operator +(LearningHubValidationResult x, LearningHubValidationResult y)
        {
            x.Add(y);
            return x;
        }

        #endregion

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="validationResult">
        /// The validation result.
        /// </param>
        public void Add(LearningHubValidationResult validationResult)
        {
            this.IsValid = this.IsValid && validationResult.IsValid;
            this.Details.AddRange(validationResult.Details);
        }
    }
}
