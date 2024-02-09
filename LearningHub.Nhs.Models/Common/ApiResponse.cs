namespace LearningHub.Nhs.Models.Common
{
    using LearningHub.Nhs.Models.Validation;

    /// <summary>
    /// The api response.
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// The has validation result.
        /// </summary>
        private bool hasValidationResult;

        /// <summary>
        /// The validation result.
        /// </summary>
        private LearningHubValidationResult validationResult;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse"/> class.
        /// </summary>
        public ApiResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse"/> class.
        /// </summary>
        /// <param name="success">
        /// The success.
        /// </param>
        public ApiResponse(bool success)
        {
            this.Success = success;
            this.ValidationResult = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse"/> class.
        /// </summary>
        /// <param name="success">
        /// The success.
        /// </param>
        /// <param name="validationResult">
        /// The validation result.
        /// </param>
        public ApiResponse(bool success, LearningHubValidationResult validationResult)
        {
            this.Success = success;
            this.ValidationResult = validationResult;
        }

        /// <summary>
        /// Gets or sets a value indicating whether success.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets Validation Result.
        /// </summary>
        public LearningHubValidationResult ValidationResult
        {
            get => this.validationResult;
            set
            {
                // Needed for Deserialization after WebAPI call
                this.validationResult = value;
                this.hasValidationResult = true;
            }
        }
    }
}
