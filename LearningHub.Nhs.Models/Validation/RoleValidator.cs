// <copyright file="RoleValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System.Linq;
    using System.Text;
    using FluentValidation;
    using LearningHub.Nhs.Models.Entities;

    /// <summary>
    /// The role validator.
    /// </summary>
    public class RoleValidator : AbstractValidator<Role>
    {
        /// <summary>
        /// The name max length.
        /// </summary>
        public const int NameMaxLength = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleValidator"/> class.
        /// </summary>
        public RoleValidator()
        {
            this.RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage($"Name length cannot exceed {NameMaxLength} characters.");

            this.RuleFor(x => x.PermissionRole)
            .Must((o, list, context) =>
            {
                var duplicates = list.Where(r => !r.Deleted)
                    .GroupBy(r => r.PermissionId)
                    .Where(d => d.Count() > 1)
                    .Select(d => d.Key)
                    .ToList();

                return !duplicates.Any();
            })
            .WithMessage((o, list) =>
            {
                var duplicates = list.Where(r => !r.Deleted)
                    .GroupBy(r => r.PermissionId)
                    .Where(d => d.Count() > 1)
                    .Select(d => d.Key)
                    .ToList();

                var sb = new StringBuilder();
                foreach (var id in duplicates)
                {
                    sb.AppendLine($"Permission with Id={id} is assigned multiple times");
                }

                return sb.ToString();
            });

            this.RuleFor(x => x.PermissionRole)
            .Must((o, list, context) =>
            {
                var invalidRoles = list.Where(r => !r.Deleted && r.RoleId != o.Id).ToList();

                return !invalidRoles.Any();
            })
            .WithMessage((o, list) =>
            {
                var invalidRoleId = list.Where(r => !r.Deleted && r.RoleId != o.Id).ToList();

                var sb = new StringBuilder();
                foreach (var r in invalidRoleId)
                {
                    sb.AppendLine($"Invalid Role Id={r.RoleId} in PermissionRole collection");
                }

                return sb.ToString();
            });

            this.RuleFor(x => x.PermissionRole)
            .Must((o, list, context) =>
            {
                return !list.Any(pr => !pr.Deleted && pr.PermissionId == 0);
            })
            .WithMessage("A Permission must exist before it can be assigned to a Role.");

            this.RuleFor(x => x.RoleUserGroup)
            .Must((o, list, context) => !(o.IsNew() && (list != null) && list.Count > 0))
            .When(x => x.IsNew())
            .WithMessage("UserGroup association is not permitted on a new Role");
        }
    }
}
