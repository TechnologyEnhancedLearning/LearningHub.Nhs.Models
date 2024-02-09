namespace LearningHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The permission role.
    /// </summary>
    public partial class PermissionRole : EntityBase, IEquatable<PermissionRole>
    {
        /// <summary>
        /// Gets or sets the permission id.
        /// </summary>
        public int PermissionId { get; set; }

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the permission.
        /// </summary>
        public virtual Permission Permission { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public virtual Role Role { get; set; }

        #region Equality

        ////public bool Equals(PermissionRole other)
        ////{
        ////    if (other == null) return false;
        ////    return (!(RoleId == 0 && other.RoleId == 0)
        ////            && RoleId == other.RoleId
        ////            && PermissionId == other.PermissionId
        ////            && Deleted == other.Deleted);
        ////}

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Equals(PermissionRole other)
        {
            if (other == null)
            {
                return false;
            }

            return this.RoleId == other.RoleId
                    && this.PermissionId == other.PermissionId
                    && this.Deleted == other.Deleted;
        }

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return this.Equals(obj as RoleUserGroup);
        }

        /// <summary>
        /// The get hash code.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return (this.RoleId, this.PermissionId).GetHashCode();
        }

        #endregion
    }
}
