// <copyright file="PermissionValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.Entities;

    /// <summary>
    /// The permission validator.
    /// </summary>
    public class PermissionValidator : AbstractValidator<Permission>
    {
        /// <summary>
        /// The name max length.
        /// </summary>
        public const int NameMaxLength = 100;

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionValidator"/> class.
        /// </summary>
        public PermissionValidator()
        {
            this.RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage(string.Format("Name length cannot exceed {0} characters.", NameMaxLength));

            this.RuleFor(x => x.PermissionRole)
            .Must((o, list, context) =>
            {
                return !(o.IsNew() && (list != null) && list.Count > 0);
            })
            .When(x => x.IsNew())
            .WithMessage("Role association is not permitted on a new Permission");
        }
    }
}
