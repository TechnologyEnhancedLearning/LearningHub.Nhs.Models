namespace elfhHub.Nhs.Models.Common
{
    /// <summary>
    /// The password create model.
    /// </summary>
    public class PasswordCreateModel : PasswordUpdateModel
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the loctoken.
        /// </summary>
        public string Loctoken { get; set; }
    }
}
