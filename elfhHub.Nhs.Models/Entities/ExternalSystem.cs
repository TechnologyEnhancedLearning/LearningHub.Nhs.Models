// <copyright file="ExternalSystem.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// ExternalSystem.
    /// </summary>
    public class ExternalSystem : EntityBase
    {
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets code.
        /// </summary>
        public string Code { get; set; }
    }
}