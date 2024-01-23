// <copyright file="User.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The user.
    /// </summary>
    public class User : EntityBase
    {
        /// <summary>
        /// The assigned roles.
        /// </summary>
        private List<Role> assignedRoles;

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            this.UserUserGroup = new HashSet<UserUserGroup>();
            this.UserNotificationAmendUser = new HashSet<UserNotification>();
            this.UserNotificationCreateUser = new HashSet<UserNotification>();
            this.UserNotificationUser = new HashSet<UserNotification>();
            this.ResourceVersion = new HashSet<ResourceVersion>();
            this.ResourceVersionEvent = new HashSet<ResourceVersionEvent>();
            this.HierarchyEdit = new HashSet<HierarchyEdit>();
            this.UserProvider = new HashSet<UserProvider>();
        }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the version start time.
        /// </summary>
        public DateTime VersionStartTime { get; set; }

        /// <summary>
        /// Gets or sets the version end time.
        /// </summary>
        public DateTime VersionEndTime { get; set; }

        /// <summary>
        /// Gets or sets the user user group.
        /// </summary>
        public virtual ICollection<UserUserGroup> UserUserGroup { get; set; }

        /// <summary>
        /// Gets or sets the resource versions.
        /// </summary>
        public virtual ICollection<ResourceVersion> ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edits.
        /// </summary>
        public virtual ICollection<HierarchyEdit> HierarchyEdit { get; set; }

        /// <summary>
        /// Gets or sets the resource version events.
        /// </summary>
        public virtual ICollection<ResourceVersionEvent> ResourceVersionEvent { get; set; }

        /// <summary>
        /// Gets the assigned roles.
        /// </summary>
        public List<Role> AssignedRoles
        {
            get
            {
                if (this.assignedRoles == null)
                {
                    this.assignedRoles = new List<Role>();
                    foreach (var uug in this.UserUserGroup)
                    {
                        foreach (var ugr in uug.UserGroup.RoleUserGroup)
                        {
                            if (this.assignedRoles.Where(r => r.Id == ugr.RoleId).FirstOrDefault() == null)
                            {
                                this.assignedRoles.Add(ugr.Role);
                            }
                        }
                    }
                }

                return this.assignedRoles;
            }
        }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the created notifications.
        /// </summary>
        [InverseProperty("CreateUser")]
        public virtual ICollection<Notification> CreatedNotifications { get; set; }

        /// <summary>
        /// Gets or sets the amended notifications.
        /// </summary>
        [InverseProperty("AmendUser")]
        public virtual ICollection<Notification> AmendedNotifications { get; set; }

        /// <summary>
        /// Gets or sets the user notification amend user.
        /// </summary>
        [NotMapped]
        public virtual ICollection<UserNotification> UserNotificationAmendUser { get; set; }

        /// <summary>
        /// Gets or sets the user notification create user.
        /// </summary>
        [NotMapped]
        public virtual ICollection<UserNotification> UserNotificationCreateUser { get; set; }

        /// <summary>
        /// Gets or sets the user notification user.
        /// </summary>
        [NotMapped]
        public virtual ICollection<UserNotification> UserNotificationUser { get; set; }

        /// <summary>
        /// Gets or sets the user provider.
        /// </summary>
        public virtual ICollection<UserProvider> UserProvider { get; set; }
    }
}
