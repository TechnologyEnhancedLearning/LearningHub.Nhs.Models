// <copyright file="EventViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.EventLog
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The event view model.
    /// </summary>
    public class EventViewModel
    {
        /// <summary>
        /// Gets or sets the event log.
        /// </summary>
        public EventLogEnum EventLog { get; set; }

        /// <summary>
        /// Gets or sets the event type.
        /// </summary>
        public EventLogEventTypeEnum EventType { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit id.
        /// </summary>
        public int? HierarchyEditId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int? NodeId { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int? ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }
    }
}
