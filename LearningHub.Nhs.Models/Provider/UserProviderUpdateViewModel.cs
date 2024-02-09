namespace LearningHub.Nhs.Models.Provider
{
    using System.Collections.Generic;

    /// <summary>
    /// The view model for modifying user provider associations via Admin.
    /// </summary>
    public class UserProviderUpdateViewModel
    {
        /// <summary>
        /// Gets or sets the provider ids.
        /// </summary>
        public List<int> ProviderIds { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }
    }
}
