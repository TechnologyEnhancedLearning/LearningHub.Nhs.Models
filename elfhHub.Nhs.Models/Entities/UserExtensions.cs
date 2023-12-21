// <copyright file="UserExtensions.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using elfhHub.Nhs.Models.Common;

    /// <summary>
    /// The user extensions.
    /// </summary>
    public static class UserExtensions
    {
        /// <summary>
        /// The to basic user.
        /// </summary>
        /// <param name="user">
        /// The user.
        /// </param>
        /// <returns>
        /// The <see cref="UserBasic"/>.
        /// </returns>
        public static UserBasic ToBasicUser(this User user)
        {
            if (user == null)
            {
                return null;
            }

            return new UserBasic
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmailAddress = user.EmailAddress,
                LastUpdated = user.AmendDate,
            };
        }
    }
}
