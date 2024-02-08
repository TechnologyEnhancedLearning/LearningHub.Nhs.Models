namespace LearningHub.Nhs.Models.OpenAthens
{
    using System.Collections.Generic;

    /// <summary>
    /// The open athens auth server payload.
    /// </summary>
    public class OpenAthensAuthServerPayload
    {
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the provider user id.
        /// </summary>
        public string ProviderUserId { get; set; }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the claims.
        /// </summary>
        public IDictionary<string, string> Claims { get; set; }
    }
}
