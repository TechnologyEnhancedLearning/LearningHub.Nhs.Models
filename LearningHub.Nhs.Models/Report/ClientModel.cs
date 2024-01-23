// <copyright file="ClientModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.Report
{
    using System;

    /// <summary>
    /// The ClientModel class.
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the client Id.
        /// </summary>
        public Guid ClientId { get; set; }
    }
}