// <copyright file="Event.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The event.
    /// </summary>
    public partial class Event : EntityBase
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
        /// Gets or sets the node.
        /// </summary>
        public virtual Node Node { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit.
        /// </summary>
        public virtual HierarchyEdit HierarchyEdit { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }
    }
}
