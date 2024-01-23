// <copyright file="UserHistoryStoredProcResults.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the result set object of the ELFH stored procedure [dbo].[proc_UserHistoryLoadForUser].
    /// </summary>
    public class UserHistoryStoredProcResults
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHistoryStoredProcResults"/> class.
        /// </summary>
        public UserHistoryStoredProcResults()
        {
        }

        /// <summary>
        /// Gets or sets the user history stored proc results.
        /// </summary>
        public List<UserHistoryStoredProcResult> Results { get; set; }

        /// <summary>
        /// Gets or sets the pages returned.
        /// </summary>
        public int TotalResults { get; set; }
    }
}