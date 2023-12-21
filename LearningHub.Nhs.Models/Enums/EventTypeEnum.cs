// <copyright file="EventTypeEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The event type enum.
    /// </summary>
    public enum EventTypeEnum
    {
        /// <summary>
        /// The search.
        /// </summary>
        Search = 1,

        /// <summary>
        /// The search sort.
        /// </summary>
        SearchSort = 2,

        /// <summary>
        /// The search filter.
        /// </summary>
        SearchFilter = 3,

        /// <summary>
        /// The search load more.
        /// </summary>
        SearchLoadMore = 4,

        /// <summary>
        /// The search launch resource.
        /// </summary>
        SearchLaunchResource = 5,

        /// <summary>
        /// The search submit feedback.
        /// </summary>
        SearchSubmitFeedback = 6,

        /// <summary>
        /// Defines the DashBoardElfh.
        /// </summary>
        DashBoardElfh = 7,

        /// <summary>
        /// Defines the DashBoardBmj.
        /// </summary>
        DashBoardBmj = 8,

        /// <summary>
        /// Defines the DashBoardResourceView.
        /// </summary>
        DashBoardResourceView = 9,

        /// <summary>
        /// The search launch catalogue.
        /// </summary>
        SearchLaunchCatalogue = 10,

        /// <summary>
        /// The launch catalogue resource.
        /// </summary>
        LaunchCatalogueResource = 11,

        /// <summary>
        /// Search Within Catalogue.
        /// </summary>
        SearchWithinCatalogue = 12,

        /// <summary>
        /// Search Within Catalogue.
        /// </summary>
        ChangeOfflineStatus = 13,

        /// <summary>
        /// Search Catalogue.
        /// </summary>
        SearchCatalogue = 14,

        /// <summary>
        /// Search Catalogue Page Change.
        /// </summary>
        SearchCataloguePageChange = 15,

        /// <summary>
        /// The Resource Page Change.
        /// </summary>
        SearchResourcePageChange = 16,

        /// <summary>
        /// The Flush All Cache.
        /// </summary>
        FlushAllCache = 17,
    }
}
