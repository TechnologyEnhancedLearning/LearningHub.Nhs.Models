// <copyright file="Location.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The location.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        public Location()
        {
            this.UserEmployment = new HashSet<UserEmployment>();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sub name.
        /// </summary>
        public string SubName { get; set; }

        /// <summary>
        /// Gets or sets the type id.
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the address 3.
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or sets the address 4.
        /// </summary>
        public string Address4 { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the post code.
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether acute.
        /// </summary>
        public bool Acute { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ambulance.
        /// </summary>
        public bool Ambulance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether mental.
        /// </summary>
        public bool Mental { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether care.
        /// </summary>
        public bool Care { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether main hosp.
        /// </summary>
        public bool MainHosp { get; set; }

        /// <summary>
        /// Gets or sets the nhs code.
        /// </summary>
        public string NhsCode { get; set; }

        /// <summary>
        /// Gets or sets the parent id.
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether import exclusion.
        /// </summary>
        public bool ImportExclusion { get; set; }

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        public int? Depth { get; set; }

        /// <summary>
        /// Gets or sets the lineage.
        /// </summary>
        public string Lineage { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Gets or sets the updated.
        /// </summary>
        public DateTimeOffset Updated { get; set; }

        /// <summary>
        /// Gets or sets the archived date.
        /// </summary>
        public DateTimeOffset? ArchivedDate { get; set; }

        /// <summary>
        /// Gets or sets the country id.
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets the igu id.
        /// </summary>
        public int IguId { get; set; }

        /// <summary>
        /// Gets or sets the letb id.
        /// </summary>
        public int LetbId { get; set; }

        /// <summary>
        /// Gets or sets the ccg id.
        /// </summary>
        public int CcgId { get; set; }

        /// <summary>
        /// Gets or sets the health service id.
        /// </summary>
        public int HealthServiceId { get; set; }

        /// <summary>
        /// Gets or sets the health board id.
        /// </summary>
        public int HealthBoardId { get; set; }

        /// <summary>
        /// Gets or sets the primary trust id.
        /// </summary>
        public int PrimaryTrustId { get; set; }

        /// <summary>
        /// Gets or sets the secondary trust id.
        /// </summary>
        public int SecondaryTrustId { get; set; }

        /// <summary>
        /// Gets or sets the island id.
        /// </summary>
        public int IslandId { get; set; }

        /// <summary>
        /// Gets or sets the other nhs organisation id.
        /// </summary>
        public int OtherNHSOrganisationId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public virtual LocationType Type { get; set; }

        /// <summary>
        /// Gets or sets the user employment.
        /// </summary>
        public virtual ICollection<UserEmployment> UserEmployment { get; set; }
    }
}
