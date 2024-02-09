namespace LearningHub.Nhs.Models.User
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The user group attribute view model.
    /// </summary>
    public partial class UserGroupAttributeViewModel
    {
        /// <summary>
        /// Gets or sets the  id.
        /// </summary>
        public int UserGroupAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user group name.
        /// </summary>
        public string UserGroupName { get; set; }

        /// <summary>
        /// Gets or sets the attribute id.
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the scope id.
        /// </summary>
        public int? ScopeId { get; set; }

        /// <summary>
        /// Gets or sets the attribute type.
        /// </summary>
        public AttributeTypeEnum AttributeType { get; set; }

        /// <summary>
        /// Gets or sets the attribute name.
        /// </summary>
        public int AttributeName { get; set; }

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

        /// <summary>
        /// Indicates whether the User Group Attribute is new.
        /// </summary>
        /// <returns>bool.</returns>
        public bool IsNew()
        {
            return this.UserGroupAttributeId == 0;
        }
    }
}
