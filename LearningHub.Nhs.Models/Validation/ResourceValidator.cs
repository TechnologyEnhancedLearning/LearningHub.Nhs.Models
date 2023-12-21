// <copyright file="ResourceValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The resource validator.
    /// </summary>
    public class ResourceValidator : AbstractValidator<Entities.Resource.Resource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceValidator"/> class.
        /// </summary>
        public ResourceValidator()
        {
        }
    }
}
