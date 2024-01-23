// <copyright file="Tenant.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The tenant.
    /// </summary>
    public class Tenant : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tenant"/> class.
        /// </summary>
        public Tenant()
        {
            this.TenantUrl = new HashSet<TenantUrl>();
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether show full catalog info message ind.
        /// </summary>
        public bool ShowFullCatalogInfoMessageInd { get; set; }

        /// <summary>
        /// Gets or sets the catalog url.
        /// </summary>
        public string CatalogUrl { get; set; }

        /// <summary>
        /// Gets or sets the quick start guide url.
        /// </summary>
        public string QuickStartGuideUrl { get; set; }

        /// <summary>
        /// Gets or sets the support form url.
        /// </summary>
        public string SupportFormUrl { get; set; }

        /// <summary>
        /// Gets or sets the live chat status.
        /// </summary>
        public int LiveChatStatus { get; set; }

        /// <summary>
        /// Gets or sets the live chat snippet.
        /// </summary>
        public string LiveChatSnippet { get; set; }

        /// <summary>
        /// Gets or sets the my elearning default view.
        /// </summary>
        public int MyElearningDefaultView { get; set; }

        /// <summary>
        /// Gets or sets the pre login catalogue default view.
        /// </summary>
        public int PreLoginCatalogueDefaultView { get; set; }

        /// <summary>
        /// Gets or sets the post login catalogue default view.
        /// </summary>
        public int PostLoginCatalogueDefaultView { get; set; }

        /// <summary>
        /// Gets or sets the auth sign on url relative.
        /// </summary>
        public string AuthSignInUrlRelative { get; set; }

        /// <summary>
        /// Gets or sets the auth sign out url relative.
        /// </summary>
        public string AuthSignOutUrlRelative { get; set; }

        /// <summary>
        /// Gets or sets the auth secret.
        /// </summary>
        public Guid AuthSecret { get; set; }

        /// <summary>
        /// Gets or sets the tenant url.
        /// </summary>
        public ICollection<TenantUrl> TenantUrl { get; set; }
    }
}
