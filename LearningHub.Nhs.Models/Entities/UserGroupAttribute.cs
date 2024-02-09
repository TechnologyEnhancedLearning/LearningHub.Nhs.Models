namespace LearningHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user group attribute.
    /// </summary>
    public partial class UserGroupAttribute : EntityBase
    {
        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the attribute id.
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the scope id.
        /// </summary>
        public int? ScopeId { get; set; }

        /// <summary>
        /// Gets or sets the user group.
        /// </summary>
        public virtual UserGroup UserGroup { get; set; }

        /// <summary>
        /// Gets or sets the attribute.
        /// </summary>
        public virtual Attribute Attribute { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        public virtual Scope Scope { get; set; }

        /// <summary>
        /// Gets or sets the int value.
        /// </summary>
        public int? IntValue { get; set; }

        /// <summary>
        /// Gets or sets the text value.
        /// </summary>
        public string TextValue { get; set; }

        /// <summary>
        /// Gets or sets the boolean value.
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Gets or sets the date value.
        /// </summary>
        public DateTimeOffset? DateValue { get; set; }
    }
}
