namespace elfhHub.Nhs.Models.Common
{
    using System;

    /// <summary>
    /// The user history view model.
    /// </summary>
    public class UserHistoryViewModel
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user history id.
        /// </summary>
        public int UserHistoryId { get; set; }

        /// <summary>
        /// Gets or sets the user history type id.
        /// </summary>
        public int UserHistoryTypeId { get; set; }

        /// <summary>
        /// Gets or sets the user history type.
        /// </summary>
        public string UserHistoryType { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the detail.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the browser name.
        /// </summary>
        public string BrowserName { get; set; }

        /// <summary>
        /// Gets or sets the browser version.
        /// </summary>
        public string BrowserVersion { get; set; }

        /// <summary>
        /// Gets or sets the url referer.
        /// </summary>
        public string UrlReferer { get; set; }

        /// <summary>
        /// Gets or sets the login ip.
        /// </summary>
        public string LoginIP { get; set; }

        /// <summary>
        /// Gets or sets the login success ful.
        /// </summary>
        public bool? LoginSuccessFul { get; set; }

        /// <summary>
        /// Gets or sets the tenant.
        /// </summary>
        public string TenantName { get; set; }
    }
}
