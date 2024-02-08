namespace LearningHub.Nhs.Models.Extensions
{
    using System.Security.Claims;
    using System.Security.Principal;

    /// <summary>
    /// The user extensions.
    /// </summary>
    public static class UserExtensions
    {
        /// <summary>
        /// The get current user id.
        /// </summary>
        /// <param name="identity">
        /// The identity.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetCurrentUserId(this IIdentity identity)
        {
            var claimsIdentity = identity as ClaimsIdentity;
            var claim = claimsIdentity?.FindFirst("sub");

            return claim == null ? 0 : int.Parse(claim.Value);
        }

        /// <summary>
        /// The get current user name.
        /// </summary>
        /// <param name="identity">
        /// The identity.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static string GetCurrentName(this IIdentity identity)
        {
            var claimsIdentity = identity as ClaimsIdentity;
            var firstName = claimsIdentity?.FindFirst("given_name");
            var lastName = claimsIdentity?.FindFirst("family_name");

            return ((firstName == null ? string.Empty : firstName.Value) + " " + (lastName == null ? string.Empty : lastName.Value)).Trim();
        }

        /// <summary>
        /// The get current user name.
        /// </summary>
        /// <param name="identity">
        /// The identity.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static string GetCurrentElfhUserName(this IIdentity identity)
        {
            var claimsIdentity = identity as ClaimsIdentity;
            var elfhUserName = claimsIdentity?.FindFirst("elfh_userName");

            return (elfhUserName == null ? string.Empty : elfhUserName.Value).Trim();
        }
    }
}
