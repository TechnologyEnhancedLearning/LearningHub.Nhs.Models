namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using System;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Resource;

    /// <summary>
    /// The resource card view model.
    /// </summary>
    public class ResourceCardViewModel : ResourceVersionViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the background image.
        /// </summary>
        public string BackgroundImage { get; set; }

        /// <summary>
        /// Gets a value indicating whether an action is required.
        /// </summary>
        public bool ActionRequired =>
            (this.VersionStatusEnum == Enums.VersionStatusEnum.Unpublished
            && this.UnpublishedByAdmin)
             ||
            (this.VersionStatusEnum == Enums.VersionStatusEnum.Published
            && this.IsFlagged)
            ||
            (this.VersionStatusEnum == Enums.VersionStatusEnum.FailedToPublish);

        /// <summary>
        /// Gets a value indicating whether card is a 'draft'.
        /// </summary>
        public bool DraftCategory => this.VersionStatusEnum == VersionStatusEnum.Draft && !this.PreviousPublishedStatusEnum.HasValue;

        /// <summary>
        /// Gets a value indicating whether card is considered 'published'.
        /// </summary>
        public bool PublishedCategory => this.VersionStatusEnum == VersionStatusEnum.Published
            || (this.InEdit && this.PreviousPublishedStatusEnum.HasValue && this.PreviousPublishedStatusEnum.Value == VersionStatusEnum.Published)
            || (this.VersionStatusEnum == VersionStatusEnum.Publishing)
            || (this.VersionStatusEnum == VersionStatusEnum.SubmittedToPublishingQueue);

        /// <summary>
        /// Gets a value indicating whether card is considered 'unpublished'.
        /// </summary>
        public bool UnpublishedCategory => this.VersionStatusEnum == VersionStatusEnum.Unpublished
            || (this.InEdit && this.PreviousPublishedStatusEnum.HasValue && this.PreviousPublishedStatusEnum.Value == VersionStatusEnum.Unpublished);

        /// <summary>
        /// Gets or sets a value indicating the previous published status.
        /// </summary>
        public VersionStatusEnum? PreviousPublishedStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether in edit.
        /// </summary>
        public bool InEdit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is flagged.
        /// </summary>
        public bool IsFlagged { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether flagged by admin.
        /// </summary>
        public bool FlaggedByAdmin { get; set; }

        /// <summary>
        /// Gets or sets the flagged by.
        /// </summary>
        public string FlaggedBy { get; set; }

        /// <summary>
        /// Gets or sets the flagged date.
        /// </summary>
        public DateTime FlaggedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the unpublished by.
        /// </summary>
        public string UnpublishedBy { get; set; }

        /// <summary>
        /// Gets or sets the unpublished date.
        /// </summary>
        public DateTime UnpublishedDate { get; set; }

        /// <summary>
        /// Gets the contributed on formatted date.
        /// </summary>
        public string ContributedOn =>
            this.VersionStatusEnum == VersionStatusEnum.Published
                ? this.PublishedDate.ToString("dd MMMM yyyy")
                : this.CreatedDate.ToString("dd MMMM yyyy");

        /// <summary>
        /// Gets or sets a value indicating whether card is read only.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has validation errors.
        /// </summary>
        public bool HasValidationErrors { get; set; }
    }
}
