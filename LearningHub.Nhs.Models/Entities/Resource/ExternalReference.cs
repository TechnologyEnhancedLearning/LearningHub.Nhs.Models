// <copyright file="ExternalReference.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ExternalReference" />.
    /// </summary>
    public partial class ExternalReference : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class.
        /// </summary>
        public ExternalReference()
        {
            this.UrlRewriting = new HashSet<UrlRewriting>();
        }

        /// <summary>
        /// Gets or sets the ResourceReferenceId.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the ExternalReference.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReference.
        /// </summary>
        public virtual ResourceReference ResourceReference { get; set; }

        /// <summary>
        /// Gets or sets the resource activity.
        /// </summary>
        public virtual ICollection<UrlRewriting> UrlRewriting { get; set; }
    }
}
