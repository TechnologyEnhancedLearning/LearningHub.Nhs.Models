namespace LearningHub.Nhs.Models.Search
{
    using System;
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Provider;
    using Newtonsoft.Json;

    /// <summary>
    /// The Document List element.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Gets or sets the batch id.
        /// </summary>
        [JsonProperty("_batchid")]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        [JsonProperty("_collection")]
        public string Collection { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the all field classifiers 30.
        /// </summary>
        [JsonProperty("all_field_classifiers_30")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> AllFieldClassifiers30 { get; set; }

        /// <summary>
        /// Gets or sets the all field classifiers 48.
        /// </summary>
        [JsonProperty("all_field_classifiers_48")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> AllFieldClassifiers48 { get; set; }

        /// <summary>
        /// Gets or sets the all field classifiers difference.
        /// </summary>
        [JsonProperty("all_field_classifiers_difference")]
        public object AllFieldClassifiersDifference { get; set; }

        /// <summary>
        /// Gets or sets the breadcrumb.
        /// </summary>
        [JsonProperty("breadcrumb")]
        public string Breadcrumb { get; set; }

        /// <summary>
        /// Gets or sets the breadcrumb id.
        /// </summary>
        [JsonProperty("breadcrumbid")]
        public string BreadcrumbId { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        [JsonProperty("category")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Category { get; set; }

        /// <summary>
        /// Gets or sets the component hierarchy id.
        /// </summary>
        [JsonProperty("componenthierarchyid")]
        public string ComponentHierarchyId { get; set; }

        /// <summary>
        /// Gets or sets the component type name.
        /// </summary>
        [JsonProperty("componenttypename")]
        public string ComponentTypeName { get; set; }

        /// <summary>
        /// Gets or sets the concepts uri.
        /// </summary>
        [JsonProperty("concepts_uri")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> ConceptsUri { get; set; }

        /// <summary>
        /// Gets or sets the concepts uri 30.
        /// </summary>
        [JsonProperty("concepts_uri_30")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> ConceptsUri30 { get; set; }

        /// <summary>
        /// Gets or sets the concepts uri 48.
        /// </summary>
        [JsonProperty("concepts_uri_48")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> ConceptsUri48 { get; set; }

        /// <summary>
        /// Gets or sets the concepts alt.
        /// </summary>
        [JsonProperty("concepts_alt")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> ConceptsAlt { get; set; }

        /// <summary>
        /// Gets or sets the concepts atl.
        /// </summary>
        [JsonProperty("concepts_atl")]
        public string ConceptsAtl { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the deleted.
        /// </summary>
        [JsonProperty("deleted")]
        public string Deleted { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /////// <summary>
        /////// Gets or sets the id.
        /////// </summary>
        ////[JsonProperty("id")]
        ////public string Id { get; set; }

        /// <summary>
        /// Gets or sets the id content object.
        /// </summary>
        [JsonProperty("id_content_object")]
        public string IdContentObject { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        [JsonProperty("keywords")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the location paths.
        /// </summary>
        [JsonProperty("location_paths")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> LocationPaths { get; set; }

        /// <summary>
        /// Gets or sets the keywords list.
        /// </summary>
        [JsonProperty("keywords_list")]
        public string KeywordsList { get; set; }

        /// <summary>
        /// Gets or sets the last versioned updated date.
        /// </summary>
        [JsonProperty("last_versioned_updated_date")]
        public DateTime LastVersionedUpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the terms.
        /// </summary>
        [JsonProperty("terms")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Terms { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        [JsonProperty("resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the resource type.
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }

        /////// <summary>
        /////// Gets or sets the all field classifiers 30.
        /////// </summary>
        ////[JsonProperty("allField_classifiers30")]
        ////public string AllFieldClassifiers30 { get; set; }

        /////// <summary>
        /////// Gets or sets the all field classifiers 48.
        /////// </summary>
        ////[JsonProperty("allField_classifiers48")]
        ////public string AllFieldClassifiers48 { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        [JsonProperty("authors")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Authors { get; set; }

        /// <summary>
        /// Gets or sets the catalogue id's.
        /// </summary>
        [JsonProperty("catalogue_ids")]
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public List<int> CatalogueIds { get; set; }

        /// <summary>
        /// Gets or sets the authored date.
        /// </summary>
        [JsonProperty("authored_date")]
        public string AuthoredDate { get; set; }

        /// <summary>
        /// Gets or sets the publication date.
        /// </summary>
        [JsonProperty("publication_date")]
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        [JsonProperty("categories")]
        public string Categories { get; set; }

        /// <summary>
        /// Gets or sets the educator.
        /// </summary>
        [JsonProperty("educator")]
        public string Educator { get; set; }

        /// <summary>
        /// Gets or sets the external url.
        /// </summary>
        [JsonProperty("external_url")]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// Gets or sets the has certificates flag.
        /// </summary>
        [JsonProperty("has_certificates")]
        public string HasCertificates { get; set; }

        /// <summary>
        /// Gets or sets the hours per week.
        /// </summary>
        [JsonProperty("hours_per_week")]
        public string HoursPerWeek { get; set; }

        /// <summary>
        /// Gets or sets the image url.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the introduction.
        /// </summary>
        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the learning outcomes.
        /// </summary>
        [JsonProperty("learning_outcomes")]
        public string LearningOutcomes { get; set; }

        /// <summary>
        /// Gets or sets the mandatory flag.
        /// </summary>
        [JsonProperty("mandatory")]
        public string Mandatory { get; set; }

        /// <summary>
        /// Gets or sets the open for enrolment flag.
        /// </summary>
        [JsonProperty("open_for_enrolment")]
        public string OpenForEnrolment { get; set; }

        /// <summary>
        /// Gets or sets the organisations.
        /// </summary>
        [JsonProperty("organisations")]
        public Organisation[] Organisations { get; set; }

        /// <summary>
        /// Gets or sets the requirements.
        /// </summary>
        [JsonProperty("requirements")]
        public string Requirements { get; set; }

        /// <summary>
        /// Gets or sets the runs.
        /// </summary>
        [JsonProperty("runs")]
        [JsonConverter(typeof(SingleOrArrayConverter<Run>))]
        public List<Run> Runs { get; set; }

        /// <summary>
        /// Gets or sets the trailer.
        /// </summary>
        [JsonProperty("trailer")]
        public string Trailer { get; set; }

        /// <summary>
        /// Gets or sets the uuid.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or sets the resource reference id.
        /// </summary>
        [JsonProperty("resource_reference_id")]
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [JsonProperty("rating")]
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets or sets the resource access level.
        /// </summary>
        [JsonProperty("resource_access_level")]
        public int ResourceAccessLevel { get; set; }

        /// <summary>
        /// Gets or sets the provider ids.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty("provider_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ProviderIds { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the catalogue url.
        /// </summary>
        public string CatalogueUrl { get; set; }

        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the catalogue badge url.
        /// </summary>
        public string CatalogueBadgeUrl { get; set; }

        /// <summary>
        /// Gets or sets the catalogue banner url.
        /// </summary>
        public string CatalogueBannerUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is restricted.
        /// </summary>
        public bool CatalogueRestrictedAccess { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has access to the resticted catalogue.
        /// </summary>
        public bool CatalogueHasAccess { get; set; }

        /// <summary>
        /// Gets or sets the resource node path id.
        /// </summary>
        public int? NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        public List<ProviderViewModel> Providers { get; set; }
    }
}
