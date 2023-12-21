// <copyright file="UserHistoryStoredProcResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the result object of the ELFH stored procedure [dbo].[proc_UserHistoryLoadForUser].
    /// </summary>
    public class UserHistoryStoredProcResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHistoryStoredProcResult"/> class.
        /// </summary>
        public UserHistoryStoredProcResult()
        {
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key]
        public int UserHistoryId { get; set; }

        /// <summary>
        /// Gets or sets the user history type id.
        /// </summary>
        public int UserHistoryTypeId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the DetailedInfo.
        /// </summary>
        public string DetailedInfo { get; set; }

        /// <summary>
        /// Gets or sets the UserAgent.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the BrowserName.
        /// </summary>
        public string BrowserName { get; set; }

        /// <summary>
        /// Gets or sets the BrowserVersion.
        /// </summary>
        public string BrowserVersion { get; set; }

        /// <summary>
        /// Gets or sets the UrlReferrer.
        /// </summary>
        public string UrlReferer { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the TenantName.
        /// </summary>
        public string TenantName { get; set; }
    }
}
