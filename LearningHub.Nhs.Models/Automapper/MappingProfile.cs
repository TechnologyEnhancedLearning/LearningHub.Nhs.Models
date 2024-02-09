namespace LearningHub.Nhs.Models.Automapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using LearningHub.Nhs.Entities.Resource;
    using LearningHub.Nhs.Models.Bookmark;
    using LearningHub.Nhs.Models.Catalogue;
    using LearningHub.Nhs.Models.Common;
    using LearningHub.Nhs.Models.Content;
    using LearningHub.Nhs.Models.Dashboard;
    using LearningHub.Nhs.Models.Entities;
    using LearningHub.Nhs.Models.Entities.Activity;
    using LearningHub.Nhs.Models.Entities.Content;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Entities.Maintenance;
    using LearningHub.Nhs.Models.Entities.Migration;
    using LearningHub.Nhs.Models.Entities.Reporting;
    using LearningHub.Nhs.Models.Entities.Resource;
    using LearningHub.Nhs.Models.Entities.Resource.Blocks;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Enums.Content;
    using LearningHub.Nhs.Models.ExternalSystem;
    using LearningHub.Nhs.Models.Hierarchy;
    using LearningHub.Nhs.Models.Log;
    using LearningHub.Nhs.Models.Maintenance;
    using LearningHub.Nhs.Models.MyLearning;
    using LearningHub.Nhs.Models.Notification;
    using LearningHub.Nhs.Models.Provider;
    using LearningHub.Nhs.Models.Report;
    using LearningHub.Nhs.Models.Report.ReportCreate;
    using LearningHub.Nhs.Models.Resource;
    using LearningHub.Nhs.Models.Resource.Activity;
    using LearningHub.Nhs.Models.Resource.AzureMediaAsset;
    using LearningHub.Nhs.Models.Resource.Blocks;
    using LearningHub.Nhs.Models.Resource.Blocks.Annotations;
    using LearningHub.Nhs.Models.Resource.Contribute;
    using LearningHub.Nhs.Models.Resource.Files;
    using LearningHub.Nhs.Models.Resource.ResourceDisplay;
    using LearningHub.Nhs.Models.RoadMap;
    using LearningHub.Nhs.Models.Search;
    using LearningHub.Nhs.Models.Search.SearchFeedback;
    using LearningHub.Nhs.Models.User;
    using Newtonsoft.Json;

    /// <summary>
    /// The mapping profile.
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingProfile"/> class.
        /// </summary>
        public MappingProfile()
        {
            this.CreateMap<Entities.External.ExternalSystem, ExternalSystemViewModel>()
                .ForMember(d => d.AmendUserName, x => x.MapFrom(s => s.AmendUser.UserName))
                .ForMember(d => d.CreateUserName, x => x.MapFrom(s => s.CreateUser.UserName));

            this.CreateMap<Entities.Notification, NotificationViewModel>()
                .ForMember(d => d.AmendUserName, x => x.MapFrom(s => s.AmendUser.UserName))
                .ForMember(d => d.CreateUserName, x => x.MapFrom(s => s.CreateUser.UserName))
                .ForMember(d => d.NotificationType, x => x.MapFrom(s => s.NotificationTypeEnum))
                .ForMember(d => d.NotificationPriority, x => x.MapFrom(s => s.NotificationPriorityEnum));

            this.CreateMap<NotificationViewModel, Entities.Notification>()
                .ForMember(d => d.NotificationTypeEnum, x => x.MapFrom(s => s.NotificationType))
                .ForMember(d => d.NotificationPriorityEnum, x => x.MapFrom(s => s.NotificationPriority));

            this.CreateMap<Entities.Log, LogViewModel>();
            this.CreateMap<LogViewModel, Entities.Log>();
            this.CreateMap<Entities.Log, LogBasicViewModel>();
            this.CreateMap<LogBasicViewModel, Entities.Log>();

            this.CreateMap<Entities.UserNotification, UserNotificationViewModel>()
                .ForMember(d => d.NotificationId, x => x.MapFrom(s => s.Notification.Id))
                .ForMember(d => d.AmendUserName, x => x.MapFrom(s => s.AmendUser.UserName))
                .ForMember(d => d.CreateUserName, x => x.MapFrom(s => s.CreateUser.UserName))
                .ForMember(d => d.UserName, x => x.MapFrom(s => s.User.UserName))
                .ForMember(d => d.Body, x => x.MapFrom(s => s.Notification.Message))
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Notification.Title))
                .ForMember(d => d.UserDismissable, x => x.MapFrom(s => s.Notification.UserDismissable))
                .ForMember(d => d.Date, x => x.MapFrom(s => s.Notification.CreateDate))
                .ForMember(d => d.NotificationType, x => x.MapFrom(s => s.Notification.NotificationTypeEnum))
                .ForMember(d => d.NotificationPriority, x => x.MapFrom(s => s.Notification.NotificationPriorityEnum));
            this.CreateMap<UserNotificationViewModel, Entities.UserNotification>();

            this.CreateMap<Entities.Resource.Resource, ResourceViewModel>()
                .ForMember(d => d.ResourceId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.ResourceType, x => x.MapFrom(s => s.ResourceTypeEnum));

            this.CreateMap<ResourceViewModel, Entities.Resource.Resource>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.ResourceId))
                .ForMember(d => d.ResourceTypeEnum, x => x.MapFrom(s => s.ResourceType));

            this.CreateMap<Entities.Resource.Resource, ResourceDetailViewModel>()
                .ForMember(d => d.ResourceId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.ResourceType, x => x.MapFrom(s => s.ResourceTypeEnum));

            this.CreateMap<ResourceDetailViewModel, Entities.Resource.Resource>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.ResourceId))
                .ForMember(d => d.ResourceTypeEnum, x => x.MapFrom(s => s.ResourceType));

            this.CreateMap<Entities.Resource.ResourceVersion, ResourceDetailViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.ResourceType, x => x.MapFrom(s => s.Resource.ResourceTypeEnum))
                .ForMember(d => d.CurrentResourceVersionId, x => x.MapFrom(s => s.Resource.CurrentResourceVersionId))
                .ForMember(d => d.CurrentResourceVersionStatusEnum, x => x.MapFrom(s => s.Resource.CurrentResourceVersion.VersionStatusEnum))
                .ForMember(d => d.ResourceAccessibilityEnum, x => x.MapFrom(s => s.ResourceAccessibilityEnum))
                .ForMember(d => d.ResourceAuthors, x => x.MapFrom(s => s.ResourceVersionAuthor))
                .ForMember(d => d.ResourceKeywords, x => x.MapFrom(s => s.ResourceVersionKeyword))
                .ForMember(d => d.ResourceProviderId, x => x.MapFrom(s => s.ResourceVersionProvider.FirstOrDefault().ProviderId));

            this.CreateMap<ResourceDetailViewModel, Entities.Resource.ResourceVersion>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.ResourceId, x => x.MapFrom(s => s.ResourceId))
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Title))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.AdditionalInformation, x => x.MapFrom(s => s.AdditionalInformation))
                .ForMember(d => d.ResourceAccessibilityEnum, x => x.MapFrom(s => s.ResourceAccessibilityEnum));

            this.CreateMap<Entities.Resource.ResourceVersion, SearchResourceRequestModel>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.Resource.Id.ToString()))
                .ForMember(d => d.ResourceType, x => x.MapFrom(s => s.Resource.ResourceTypeEnum.ToString()))
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Title))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.Authors, x => x.MapFrom(s => s.ResourceVersionAuthor.Select(a => string.IsNullOrEmpty(a.AuthorName) ? a.Organisation : (string.IsNullOrEmpty(a.Organisation) ? a.AuthorName : a.AuthorName + ", " + a.Organisation))))
                .ForMember(d => d.Keywords, x => x.MapFrom(s => s.ResourceVersionKeyword.Select(k => k.Keyword)))
                .ForMember(d => d.PublicationId, x => x.MapFrom(s => s.Publication.Id))
                .ForMember(d => d.PublicationDate, x => x.MapFrom(s => s.Publication.CreateDate))
                .ForMember(d => d.Rating, x => x.MapFrom(s => s.ResourceVersionRatingSummary.AverageRating))
                .ForMember(d => d.ResourceAccessLevel, x => x.MapFrom(s => Convert.ToInt32(s.ResourceAccessibilityEnum)))
                .ForMember(d => d.ProviderIds, x => x.MapFrom(s => s.ResourceVersionProvider.Select(k => k.ProviderId)));

            this.CreateMap<Entities.Resource.File, FileViewModel>()
                .ForMember(d => d.FileId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.FileName, x => x.MapFrom(s => s.FileName))
                .ForMember(d => d.FilePath, x => x.MapFrom(s => s.FilePath))
                .ForMember(d => d.FileSizeKb, x => x.MapFrom(s => s.FileSizeKb))
                .ForMember(d => d.FileTypeId, x => x.MapFrom(s => s.FileTypeId))
                .ForMember(d => d.FileChunkDetailId, x => x.MapFrom(s => s.FileChunkDetailId))
                .ForMember(d => d.FileType, x => x.MapFrom(s => s.FileType))
                .ForMember(d => d.PartialFile, x => x.MapFrom(s => s.PartialFile))
                .ForMember(d => d.VideoFile, x => x.MapFrom(s => s.VideoFile))
                .ForMember(d => d.WholeSlideImageFile, x => x.MapFrom(s => s.WholeSlideImageFile));

            this.CreateMap<FileViewModel, Entities.Resource.File>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.FileId))
                .ForMember(d => d.PartialFile, x => x.Ignore())
                .ForMember(d => d.WholeSlideImageFile, x => x.Ignore());

            this.CreateMap<Models.Resource.Contribute.FileChunkDetailViewModel, Entities.Resource.FileChunkDetail>();
            this.CreateMap<Entities.Resource.FileChunkDetail, Models.Resource.Contribute.FileChunkDetailViewModel>();

            this.CreateMap<Models.Content.FileChunkDetailViewModel, Entities.Resource.FileChunkDetail>();
            this.CreateMap<Entities.Resource.FileChunkDetail, Models.Content.FileChunkDetailViewModel>();

            this.CreateMap<Entities.Resource.GenericFileResourceVersion, GenericFileViewModel>();
            this.CreateMap<GenericFileViewModel, Entities.Resource.GenericFileResourceVersion>();
            this.CreateMap<Entities.Resource.GenericFileResourceVersion, GenericFileUpdateRequestViewModel>();
            this.CreateMap<GenericFileUpdateRequestViewModel, Entities.Resource.GenericFileResourceVersion>();

            this.CreateMap<Entities.Resource.ImageResourceVersion, ImageViewModel>();
            this.CreateMap<ImageViewModel, Entities.Resource.ImageResourceVersion>();
            this.CreateMap<Entities.Resource.ImageResourceVersion, ImageUpdateRequestViewModel>();
            this.CreateMap<ImageUpdateRequestViewModel, Entities.Resource.ImageResourceVersion>();

            this.CreateMap<Entities.Resource.VideoResourceVersion, VideoViewModel>();
            this.CreateMap<VideoViewModel, Entities.Resource.VideoResourceVersion>();
            this.CreateMap<Entities.Resource.VideoResourceVersion, VideoUpdateRequestViewModel>();
            this.CreateMap<VideoUpdateRequestViewModel, Entities.Resource.VideoResourceVersion>();

            this.CreateMap<Entities.Resource.AudioResourceVersion, AudioViewModel>();
            this.CreateMap<AudioViewModel, Entities.Resource.AudioResourceVersion>();

            this.CreateMap<Entities.Resource.ScormResourceVersionManifest, ScormManifestViewModel>();
            this.CreateMap<ScormManifestViewModel, Entities.Resource.ScormResourceVersionManifest>();

            this.CreateMap<Entities.Resource.ScormResourceVersion, ScormViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.DevelopmentId, x => x.MapFrom(s => s.DevelopmentId))
                .ForMember(d => d.ContentFilePath, x => x.MapFrom(s => s.ContentFilePath))
                .ForMember(d => d.EsrLinkType, x => x.MapFrom(s => (EsrLinkType)s.EsrLinkTypeId))
                .ForMember(d => d.PopupWidth, x => x.MapFrom(s => s.PopupWidth.HasValue ? s.PopupWidth.Value : 1024))
                .ForMember(d => d.PopupHeight, x => x.MapFrom(s => s.PopupHeight.HasValue ? s.PopupHeight.Value : 768))
                .ForMember(d => d.UseDefaultPopupWindowSize, x => x.MapFrom(s => !s.PopupWidth.HasValue && !s.PopupHeight.HasValue))
                .ForMember(d => d.ScormManifest, x => x.MapFrom(s => s.ScormResourceVersionManifest))
                .ForMember(d => d.ClearSuspendData, x => x.MapFrom(s => s.ClearSuspendData));

            this.CreateMap<ScormViewModel, Entities.Resource.ScormResourceVersion>();

            this.CreateMap<ScormUpdateRequestViewModel, ScormResourceVersion>()
                .ForMember(d => (EsrLinkType)d.EsrLinkTypeId, x => x.MapFrom(s => s.EsrLinkType))
                .ForMember(d => d.PopupWidth, x => x.MapFrom(s => s.UseDefaultPopupWindowSize ? null : s.PopupWidth as int?))
                .ForMember(d => d.PopupHeight, x => x.MapFrom(s => s.UseDefaultPopupWindowSize ? null : s.PopupHeight as int?));

            this.CreateMap<Entities.Resource.ScormResourceVersion, ScormPublishUpdateViewModel>();
            this.CreateMap<ScormPublishUpdateViewModel, Entities.Resource.ScormResourceVersion>();

            this.CreateMap<Entities.Resource.ScormResourceVersionManifest, ScormManifestUpdateRequestViewModel>();
            this.CreateMap<ScormManifestUpdateRequestViewModel, Entities.Resource.ScormResourceVersionManifest>();
            this.CreateMap<ExternalReferenceUserAgreementViewModel, ExternalReferenceUserAgreement>();

            this.CreateMap<Entities.Resource.ResourceVersionValidationResult, ResourceVersionValidationResultViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.ResourceVersionTitle, x => x.MapFrom(s => s.ResourceVersion.Title))
                .ForMember(d => d.VersionStatus, x => x.MapFrom(s => s.ResourceVersion.VersionStatusEnum))
                .ForMember(d => d.ResourceVersionCreateUserId, x => x.MapFrom(s => s.ResourceVersion.CreateUserId))
                .ForMember(d => d.HasPublishedVersion, x => x.MapFrom(s => s.ResourceVersion.MajorVersion.HasValue))
                .ForMember(d => d.VersionDescription, x => x.MapFrom(s => (s.ResourceVersion.MajorVersion.HasValue || s.ResourceVersion.MinorVersion.HasValue) ? string.Format("{0}.{1}", s.ResourceVersion.MajorVersion.Value.ToString(), s.ResourceVersion.MinorVersion.Value.ToString()) : null))
                .ForMember(d => d.ResourceVersionValidationRuleResultViewModels, x => x.MapFrom(s => s.ResourceVersionValidationRuleResults))
                .ForMember(d => d.Success, x => x.MapFrom(s => s.Success))
                .ForMember(d => d.Details, x => x.MapFrom(s => s.Details))
                .ForMember(d => d.CreateUser, x => x.MapFrom(s => s.CreateUser.UserName));

            this.CreateMap<ResourceVersionValidationResultViewModel, Entities.Resource.ResourceVersionValidationResult>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.ResourceVersionValidationRuleResults, x => x.MapFrom(s => s.ResourceVersionValidationRuleResultViewModels))
                .ForMember(d => d.Success, x => x.MapFrom(s => s.Success))
                .ForMember(d => d.Details, x => x.MapFrom(s => s.Details));

            this.CreateMap<Entities.Resource.ResourceVersionValidationRuleResult, ResourceVersionValidationRuleResultViewModel>();
            this.CreateMap<ResourceVersionValidationRuleResultViewModel, Entities.Resource.ResourceVersionValidationRuleResult>();

            this.CreateMap<Entities.Resource.ResourceVersionAuthor, ResourceAuthorViewModel>();
            this.CreateMap<ResourceAuthorViewModel, Entities.Resource.ResourceVersionAuthor>();

            this.CreateMap<Entities.Resource.ResourceVersionKeyword, ResourceKeywordViewModel>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.Keyword, x => x.MapFrom(s => s.Keyword));
            this.CreateMap<ResourceKeywordViewModel, Entities.Resource.ResourceVersionKeyword>();

            this.CreateMap<Entities.Address, AddressViewModel>()
                .ForMember(d => d.Address1, x => x.MapFrom(s => s.Address1))
                .ForMember(d => d.Address2, x => x.MapFrom(s => s.Address2))
                .ForMember(d => d.Address3, x => x.MapFrom(s => s.Address3))
                .ForMember(d => d.Address4, x => x.MapFrom(s => s.Address4))
                .ForMember(d => d.County, x => x.MapFrom(s => s.County))
                .ForMember(d => d.Town, x => x.MapFrom(s => s.Town))
                .ForMember(d => d.PostCode, x => x.MapFrom(s => s.PostCode));

            this.CreateMap<Entities.Resource.ImageResourceVersion, ImageViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.AltTag, x => x.MapFrom(s => s.AltTag))
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForMember(d => d.ImageFileId, x => x.MapFrom(s => s.ImageFileId));

            this.CreateMap<Entities.Resource.GenericFileResourceVersion, GenericFileViewModel>();

            this.CreateMap<Entities.Resource.EquipmentResourceVersion, EquipmentViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.ContactName, x => x.MapFrom(s => s.ContactName))
                .ForMember(d => d.ContactEmail, x => x.MapFrom(s => s.ContactEmail))
                .ForMember(d => d.ContactTelephone, x => x.MapFrom(s => s.ContactTelephone))
                .ForMember(d => d.Address, x => x.MapFrom(s => s.Address));

            this.CreateMap<Entities.Resource.WebLinkResourceVersion, WebLinkViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.DisplayText, x => x.MapFrom(s => s.DisplayText))
                .ForMember(d => d.Url, x => x.MapFrom(s => s.WebLinkUrl));

            this.CreateMap<WebLinkViewModel, Entities.Resource.WebLinkResourceVersion>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.DisplayText, x => x.MapFrom(s => s.DisplayText))
                .ForMember(d => d.WebLinkUrl, x => x.MapFrom(s => s.Url));

            this.CreateMap<Entities.Resource.ArticleResourceVersion, ArticleViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Content))
                .ForMember(d => d.Files, x => x.MapFrom(s => s.ArticleResourceVersionFile));

            this.CreateMap<ArticleViewModel, Entities.Resource.ArticleResourceVersion>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.Content, x => x.MapFrom(s => s.Description));

            this.CreateMap<Entities.Resource.ArticleResourceVersionFile, FileViewModel>()
                .ForMember(d => d.FileName, x => x.MapFrom(s => s.File.FileName))
                .ForMember(d => d.FilePath, x => x.MapFrom(s => s.File.FilePath))
                .ForMember(d => d.FileChunkDetailId, x => x.MapFrom(s => s.File.FileChunkDetailId))
                .ForMember(d => d.FileSizeKb, x => x.MapFrom(s => s.File.FileSizeKb))
                .ForMember(d => d.FileType, x => x.MapFrom(s => s.File.FileType));

            this.CreateMap<Entities.Resource.ArticleResourceVersion, ArticleUpdateRequestViewModel>()
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Content));
            this.CreateMap<ArticleUpdateRequestViewModel, Entities.Resource.ArticleResourceVersion>()
                .ForMember(d => d.Content, x => x.MapFrom(s => s.Description));

            this.CreateMap<FileType, FileTypeViewModel>();
            this.CreateMap<FileTypeViewModel, FileType>();

            this.CreateMap<ResourceLicence, ResourceLicenceViewModel>();
            this.CreateMap<ResourceLicenceViewModel, ResourceLicence>();

            this.CreateMap<ResourceVersionFlag, ResourceVersionFlagViewModel>()
                .ForMember(d => d.FlaggedByUserId, x => x.MapFrom(s => s.CreateUserId));
            this.CreateMap<ResourceVersionFlagViewModel, ResourceVersionFlag>();

            this.CreateMap<ResourceVersionEvent, ResourceVersionEventViewModel>()
                .ForMember(d => d.CreateUser, x => x.MapFrom(s => s.CreateUser.UserName));
            this.CreateMap<ResourceVersionEventViewModel, ResourceVersionEvent>();

            this.CreateMap<ScormResourceReferenceEvent, ScormResourceReferenceEventViewModel>()
                .ForMember(d => d.ScormResourceReferenceEventType, x => x.MapFrom(s => (ScormResourceReferenceEventTypeEnum)s.ScormResourceReferenceEventTypeId));
            this.CreateMap<ScormResourceReferenceEventViewModel, ScormResourceReferenceEvent>()
                .ForMember(d => (ScormResourceReferenceEventTypeEnum)d.ScormResourceReferenceEventTypeId, x => x.MapFrom(s => s.ScormResourceReferenceEventType));

            this.CreateMap<ResourceVersion, ResourceAdminSearchResultViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.ResourceTypeEnum, x => x.MapFrom(s => s.Resource.ResourceTypeEnum))
                .ForMember(d => d.CreateUser, x => x.MapFrom(s => s.CreateUser.UserName))
                .ForMember(d => d.ResourceReferenceIds, x => x.MapFrom(s => s.Resource.ResourceReference.Select(rr => rr.OriginalResourceReferenceId)));
            this.CreateMap<ResourceAdminSearchResultViewModel, ResourceVersion>();

            this.CreateMap<Entities.Resource.ResourceAzureMediaAsset, ResourceAzureMediaAssetViewModel>();

            this.CreateMap<MediaAssetOutputViewModel, Entities.Resource.ResourceAzureMediaAsset>();
            this.CreateMap<MediaAssetInputViewModel, MediaAssetOutputViewModel>();

            this.CreateMap<ResourceVersionRatingSummary, RatingSummaryViewModel>()
                .ForMember(d => d.EntityVersionId, x => x.MapFrom(s => s.ResourceVersionId));

            this.CreateMap<ResourceVersionRatingSummary, RatingSummaryBasicViewModel>()
                .ForMember(d => d.EntityVersionId, x => x.MapFrom(s => s.ResourceVersionId));

            this.CreateMap<CreateAssessmentResourceActivityViewModel, AssessmentResourceActivity>()
                .ForMember(d => d.Reason, x => x.MapFrom(s => s.ExtraAttemptReason))
                .ForMember(d => d.MatchQuestions, x => x.MapFrom(s => s.MatchQuestions));

            this.CreateMap<CreateAssessmentResourceActivityViewModel, AssessmentResourceActivity>()
                .ForMember(d => d.Reason, x => x.MapFrom(s => s.ExtraAttemptReason))
                .ForMember(d => d.MatchQuestions, x => x.MapFrom(s => s.MatchQuestions));

            this.CreateMap<AssessmentResourceActivityMatchQuestionViewModel, AssessmentResourceActivityMatchQuestion>();

            this.CreateMap<AssessmentResourceActivityMatchQuestion, AssessmentResourceActivityMatchQuestionViewModel>();

            this.CreateMap<SearchRequestModel, SearchEventModel>();
            this.CreateMap<CatalogueSearchRequestModel, SearchCatalogueEventModel>();

            this.CreateMap<CatalogueNodeVersion, CatalogueBasicViewModel>()
                .ForMember(d => d.Hidden, x => x.MapFrom(s => s.NodeVersion.Node.Hidden))
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.NodeVersion.NodeId))
                .ForMember(d => d.BadgeUrl, x => x.MapFrom(s => s.BadgeUrl));

            this.CreateMap<CatalogueNodeVersion, CatalogueViewModel>()
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.NodeVersion.NodeId))
                .ForMember(d => d.NodeVersionId, x => x.MapFrom(s => s.NodeVersion.Id))
                .ForMember(d => d.CatalogueNodeVersionId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.Hidden, x => x.MapFrom(s => s.NodeVersion.Node.Hidden))
                .ForMember(d => d.RestrictedAccess, x => x.MapFrom(s => s.RestrictedAccess))
                .ForMember(d => d.Status, x => x.MapFrom(s => s.NodeVersion.VersionStatusEnum))
                .ForMember(d => d.BadgeUrl, x => x.MapFrom(s => s.BadgeUrl))
                .ForMember(d => d.BannerUrl, x => x.MapFrom(s => s.BannerUrl))
                .ForMember(d => d.CertificateUrl, x => x.MapFrom(s => s.CertificateUrl))
                .ForMember(d => d.Keywords, x => x.MapFrom(s => s.Keywords.Select(k => k.Keyword)))
                .ForMember(d => d.ResourceOrder, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.Notes, x => x.MapFrom(s => s.Notes))
                .ForMember(d => d.Name, x => x.MapFrom(s => s.Name))
                .ForMember(d => d.OwnerEmailAddress, x => x.MapFrom(s => s.OwnerEmailAddress))
                .ForMember(d => d.OwnerName, x => x.MapFrom(s => s.OwnerName))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.LastModifiedDate, x => x.MapFrom(s => s.AmendDate.UtcDateTime));

            this.CreateMap<CatalogueNodeVersion, CatalogueOwnerViewModel>()
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.NodeVersion.NodeId))
                .ForMember(d => d.NodeVersionId, x => x.MapFrom(s => s.NodeVersion.Id))
                .ForMember(d => d.CatalogueNodeVersionId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.OwnerEmailAddress, x => x.MapFrom(s => s.OwnerEmailAddress))
                .ForMember(d => d.OwnerName, x => x.MapFrom(s => s.OwnerName));

            this.CreateMap<CatalogueNodeVersion, SearchCatalogueRequestModel>()
                .ForMember(x => x.Id, x => x.MapFrom(y => y.NodeVersion.NodeId))
                .ForMember(x => x.Description, x => x.MapFrom(y => y.Description))
                .ForMember(x => x.Name, x => x.MapFrom(y => y.Name))
                .ForMember(x => x.Keywords, x => x.MapFrom(y => y.Keywords.Select(z => z.Keyword)))
                .ForMember(x => x.Hidden, x => x.MapFrom(y => y.NodeVersion.Node.Hidden))
                .ForMember(x => x.ProviderIds, x => x.MapFrom(y => new List<int> { y.CatalogueNodeVersionProvider.ProviderId }));

            this.CreateMap<FolderNodeVersion, FolderViewModel>()
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.NodeVersion.NodeId))
                .ForMember(d => d.NodeVersionId, x => x.MapFrom(s => s.NodeVersion.Id))
                .ForMember(d => d.FolderNodeVersionId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.Name, x => x.MapFrom(s => s.Name))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.LastModifiedDate, x => x.MapFrom(s => s.AmendDate.UtcDateTime));

            this.CreateMap<NodeResource, NodeResourceLookupViewModel>()
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.NodeId))
                .ForMember(d => d.ResourceId, x => x.MapFrom(s => s.ResourceId));

            this.CreateMap<NodeResourceLookup, NodeResourceLookupViewModel>()
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.NodeId))
                .ForMember(d => d.ResourceId, x => x.MapFrom(s => s.ResourceId));

            this.CreateMap<NodePath, NodePathViewModel>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.NodeId))
                .ForMember(d => d.NodePathString, x => x.MapFrom(s => s.NodePathString))
                .ForMember(d => d.IsActive, x => x.MapFrom(s => s.IsActive))
                .ForMember(d => d.CatalogueNodeId, x => x.MapFrom(s => s.CatalogueNodeId));

            this.CreateMap<HierarchyEdit, HierarchyEditViewModel>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.NodeId, x => x.MapFrom(s => s.RootNodeId))
                .ForMember(d => d.NodeName, x => x.MapFrom(s => s.RootNode.CurrentNodeVersion.FolderNodeVersion.Name))
                .ForMember(d => d.HierarchyEditStatus, x => x.MapFrom(s => s.HierarchyEditStatus))
                .ForMember(d => d.LastPublishedDate, x => x.MapFrom(s => s.Publication.CreateDate))
                .ForMember(d => d.UserId, x => x.MapFrom(s => s.CreateUserId))
                .ForMember(d => d.Username, x => x.MapFrom(s => s.CreateUser.UserName))
                .ForMember(d => d.CreateDate, x => x.MapFrom(s => s.CreateDate));

            this.CreateMap<ResourceContributionDto, ContributedResourceCardViewModel>()
                .ForMember(d => d.ResourceTypeEnum, x => x.MapFrom(s => (ResourceTypeEnum)s.ResourceTypeId))
                .ForMember(d => d.VersionStatusEnum, x => x.MapFrom(s => (VersionStatusEnum)s.VersionStatusId))
                .ForMember(d => d.ResourceAccessibilityEnum, x => x.MapFrom(s => (ResourceAccessibilityEnum)s.ResourceAccessibilityId))
                .ForMember(d => d.PublishedDate, x => x.MapFrom(s => s.PublishedDate.HasValue ? ((DateTimeOffset)s.PublishedDate).DateTime : DateTime.MinValue))
                .ForMember(d => d.CreatedDate, x => x.MapFrom(s => s.CreatedDate.DateTime));

            this.CreateMap<ResourceVersion, MyContributionsBasicDetailsViewModel>()
                .ForMember(d => d.ResourceId, x => x.MapFrom(s => s.ResourceId))
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Title));

            this.CreateMap<UserCreateViewModel, User>();
            this.CreateMap<UserUpdateViewModel, User>();
            this.CreateMap<User, UserLHBasicViewModel>();

            this.CreateMap<UserGroup, UserGroupAdminBasicViewModel>()
                .ForMember(d => d.HasCatalogues, x => x.MapFrom(l => l.RoleUserGroup != null
                    ? l.RoleUserGroup.Any(rug => rug.Scope != null && rug.Scope.ScopeType == ScopeTypeEnum.Catalogue)
                    : false));
            this.CreateMap<UserGroup, UserGroupAdminDetailViewModel>()
                .ForMember(d => d.HasCatalogues, x => x.MapFrom(l => l.RoleUserGroup != null
                    ? l.RoleUserGroup.Any(rug => rug.Scope != null && rug.Scope.ScopeType == ScopeTypeEnum.Catalogue)
                    : false))
                .ForMember(d => d.OriginalName, x => x.MapFrom(l => l.Name))
                .ForMember(d => d.OriginalDescription, x => x.MapFrom(l => l.Description));

            this.CreateMap<UserUserGroup, UserUserGroupViewModel>()
                .ForMember(d => d.Id, x => x.MapFrom(l => l.Id))
                .ForMember(d => d.UserGroupId, x => x.MapFrom(l => l.UserGroupId))
                .ForMember(d => d.UserGroupName, x => x.MapFrom(s => s.UserGroup.Name))
                .ForMember(d => d.UserId, x => x.MapFrom(l => l.UserId))
                .ForMember(d => d.UserName, x => x.MapFrom(s => s.User.UserName));

            this.CreateMap<UserUserGroupViewModel, UserUserGroup>()
                .ForMember(d => d.Id, x => x.MapFrom(l => l.Id))
                .ForMember(d => d.UserGroupId, x => x.MapFrom(l => l.UserGroupId))
                .ForMember(d => d.UserId, x => x.MapFrom(l => l.UserId));

            this.CreateMap<User, UserAdminBasicViewModel>();
            this.CreateMap<UserAdminBasicViewModel, User>();

            this.CreateMap<RoleUserGroup, RoleUserGroupViewModel>()
                .ForMember(d => d.RoleUserGroupId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.UserGroupId, x => x.MapFrom(s => s.UserGroupId))
                .ForMember(d => d.UserGroupName, x => x.MapFrom(s => s.UserGroup.Name))
                .ForMember(d => d.ScopeId, x => x.MapFrom(s => s.ScopeId))
                .ForMember(d => d.ScopeType, x => x.MapFrom(s => s.ScopeId.HasValue ? s.Scope.ScopeType as ScopeTypeEnum? : null))
                .ForMember(d => d.CatalogueNodeId, x => x.MapFrom(s => s.ScopeId.HasValue ? s.Scope.CatalogueNodeId : null))
                .ForMember(d => d.CatalogueNodeVersionId, x => x.MapFrom(s => (s.ScopeId.HasValue && s.Scope.CatalogueNodeId.HasValue) ? s.Scope.CatalogueNode.CurrentNodeVersion.CatalogueNodeVersion.Id as int? : null))
                .ForMember(d => d.CatalogueName, x => x.MapFrom(s => (s.ScopeId.HasValue && s.Scope.CatalogueNodeId.HasValue) ? s.Scope.CatalogueNode.CurrentNodeVersion.CatalogueNodeVersion.Name : null))
                .ForMember(d => d.RoleId, x => x.MapFrom(s => s.RoleId))
                .ForMember(d => d.RoleName, x => x.MapFrom(s => s.Role.Name))
                .ForMember(d => d.RoleEnum, x => x.MapFrom(s => (RoleEnum)s.RoleId));

            this.CreateMap<UserGroupAttribute, UserGroupAttributeViewModel>()
                .ForMember(d => d.UserGroupAttributeId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.UserGroupId, x => x.MapFrom(s => s.UserGroupId))
                .ForMember(d => d.UserGroupName, x => x.MapFrom(s => s.UserGroup.Name))
                .ForMember(d => d.AttributeId, x => x.MapFrom(s => s.AttributeId))
                .ForMember(d => d.ScopeId, x => x.MapFrom(s => s.ScopeId))
                .ForMember(d => d.AttributeType, x => x.MapFrom(s => s.Attribute.AttributeTypeEnum))
                .ForMember(d => d.AttributeName, x => x.MapFrom(s => s.Attribute.Name))
                .ForMember(d => d.IntValue, x => x.MapFrom(s => s.IntValue))
                .ForMember(d => d.TextValue, x => x.MapFrom(s => s.TextValue))
                .ForMember(d => d.BooleanValue, x => x.MapFrom(s => s.BooleanValue))
                .ForMember(d => d.DateValue, x => x.MapFrom(s => s.DateValue));

            this.CreateMap<UserGroupAttributeViewModel, UserGroupAttribute>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.UserGroupAttributeId))
                .ForMember(d => d.UserGroupId, x => x.MapFrom(s => s.UserGroupId))
                .ForMember(d => d.AttributeId, x => x.MapFrom(s => s.AttributeId))
                .ForMember(d => d.ScopeId, x => x.MapFrom(s => s.ScopeId))
                .ForMember(d => d.IntValue, x => x.MapFrom(s => s.IntValue))
                .ForMember(d => d.TextValue, x => x.MapFrom(s => s.TextValue))
                .ForMember(d => d.BooleanValue, x => x.MapFrom(s => s.BooleanValue))
                .ForMember(d => d.DateValue, x => x.MapFrom(s => s.DateValue));

            this.CreateMap<CatalogueAccessRequest, CatalogueAccessRequestViewModel>()
                .ForMember(x => x.DateApproved, x => x.MapFrom(y => y.Status == (int)CatalogueAccessRequestStatus.Accepted ? y.CompletedDate : null))
                .ForMember(x => x.DateRejected, x => x.MapFrom(y => y.Status == (int)CatalogueAccessRequestStatus.Rejected ? y.CompletedDate : null))
                .ForMember(x => x.DateRequested, x => x.MapFrom(y => y.CreateDate))
                .ForMember(x => x.EmailAddress, x => x.MapFrom(y => y.UserProfile.EmailAddress))
                .ForMember(x => x.Username, x => x.MapFrom(y => y.User.UserName))
                .ForMember(x => x.UserFullName, x => x.MapFrom(y => y.UserProfile.FirstName + " " + y.UserProfile.LastName))
                .ForMember(x => x.Id, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.Message, x => x.MapFrom(y => y.Message))
                .ForMember(x => x.Status, x => x.MapFrom(y => (CatalogueAccessRequestStatus)y.Status))
                .ForMember(x => x.UserId, x => x.MapFrom(y => y.UserId));

            this.CreateMap<UserProfile, RestrictedCatalogueUserViewModel>()
                .ForMember(x => x.Username, x => x.MapFrom(y => y.UserName))
                .ForMember(x => x.FullName, x => x.MapFrom(y => y.FirstName + " " + y.LastName))
                .ForMember(x => x.EmailAddress, x => x.MapFrom(y => y.EmailAddress));

            this.CreateMap<MediaResourcePlayedSegment, PlayedSegmentViewModel>();

            this.CreateMap<DashboardResourceDto, DashboardResourceViewModel>()
                .ForMember(d => d.ResourceType, x => x.MapFrom(s => (ResourceTypeEnum)s.ResourceTypeId));
            this.CreateMap<DashboardCatalogueDto, DashboardCatalogueViewModel>();
            this.CreateMap<Roadmap, RoadMapViewModel>();

            this.CreateMap<MigrationSource, MigrationSourceViewModel>();

            this.CreateMap<BlockCollection, BlockCollectionViewModel>()
                .ForMember(d => d.Blocks, x => x.MapFrom(s => s.Blocks))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<BlockCollectionViewModel, BlockCollection>()
                .ForMember(d => d.Blocks, x => x.MapFrom(s => s.Blocks))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<Block, BlockViewModel>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Title))
                .ForMember(d => d.BlockType, x => x.MapFrom(s => s.BlockType))
                .ForMember(d => d.TextBlock, x => x.MapFrom(s => s.TextBlock))
                .ForMember(d => d.WholeSlideImageBlock, x => x.MapFrom(s => s.WholeSlideImageBlock))
                .ForMember(d => d.MediaBlock, x => x.MapFrom(s => s.MediaBlock))
                .ForMember(d => d.QuestionBlock, x => x.MapFrom(s => s.QuestionBlock))
                .ForMember(d => d.ImageCarouselBlock, x => x.MapFrom(s => s.ImageCarouselBlock))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<BlockViewModel, Block>()
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Title))
                .ForMember(d => d.BlockType, x => x.MapFrom(s => s.BlockType))
                .ForMember(d => d.TextBlock, x => x.MapFrom(s => s.TextBlock))
                .ForMember(d => d.WholeSlideImageBlock, x => x.MapFrom(s => s.WholeSlideImageBlock))
                .ForMember(d => d.MediaBlock, x => x.MapFrom(s => s.MediaBlock))
                .ForMember(d => d.QuestionBlock, x => x.MapFrom(s => s.QuestionBlock))
                .ForMember(d => d.ImageCarouselBlock, x => x.MapFrom(s => s.ImageCarouselBlock))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<TextBlock, TextBlockViewModel>()
                .ForMember(d => d.Content, x => x.MapFrom(s => s.Content))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<TextBlockViewModel, TextBlock>()
                .ForMember(d => d.Content, x => x.MapFrom(s => s.Content))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImageBlock, WholeSlideImageBlockViewModel>()
                .ForMember(d => d.WholeSlideImageBlockItems, x => x.MapFrom(s => s.WholeSlideImageBlockItems))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImageBlockViewModel, WholeSlideImageBlock>()
                .ForMember(d => d.WholeSlideImageBlockItems, x => x.MapFrom(s => s.WholeSlideImageBlockItems))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImageBlockItem, WholeSlideImageBlockItemViewModel>()
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.WholeSlideImage, x => x.MapFrom(s => s.WholeSlideImage))
                .ForMember(d => d.PlaceholderText, x => x.MapFrom(s => s.PlaceholderText))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImageBlockItemViewModel, WholeSlideImageBlockItem>()
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.WholeSlideImage, x => x.MapFrom(s => s.WholeSlideImage))
                .ForMember(d => d.PlaceholderText, x => x.MapFrom(s => s.PlaceholderText))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImage, WholeSlideImageViewModel>()
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Title))
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForMember(d => d.Annotations, x => x.MapFrom(s => s.ImageAnnotations))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImageViewModel, WholeSlideImage>()
                .ForMember(d => d.Title, x => x.MapFrom(s => s.Title))
                .ForMember(d => d.FileId, x => x.MapFrom(s => s.File.FileId != 0 ? s.File.FileId : (int?)null))
                .ForMember(d => d.ImageAnnotations, x => x.MapFrom(s => s.Annotations))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<PartialFile, PartialFileViewModel>()
                .ForMember(d => d.FileId, x => x.MapFrom(s => s.File.Id))
                .ForMember(d => d.FileName, x => x.MapFrom(s => s.File.FileName))
                .ForMember(d => d.FilePath, x => x.MapFrom(s => s.File.FilePath))
                .ForMember(d => d.TotalFileSize, x => x.MapFrom(s => s.TotalSize))
                .ForMember(d => d.PostProcessingOptions, x => x.MapFrom(s => s.File.WholeSlideImageFile != null ? PartialFilePostProcessingOptions.WholeSlideImage : PartialFilePostProcessingOptions.None))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImageFile, WholeSlideImageFileViewModel>()
                .ForMember(d => d.Status, x => x.MapFrom(s => s.Status))
                .ForMember(d => d.Width, x => x.MapFrom(s => s.Width))
                .ForMember(d => d.Height, x => x.MapFrom(s => s.Height))
                .ForMember(d => d.DeepZoomTileSize, x => x.MapFrom(s => s.DeepZoomTileSize))
                .ForMember(d => d.DeepZoomOverlap, x => x.MapFrom(s => s.DeepZoomOverlap))
                .ForMember(d => d.Layers, x => x.MapFrom(s => s.Layers))
                .ForMember(d => d.ProcessingErrorMessage, x => x.MapFrom(s => s.ProcessingErrorMessage))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<WholeSlideImageFileViewModel, WholeSlideImageFile>()
                .ForMember(d => d.Status, x => x.MapFrom(s => s.Status))
                .ForMember(d => d.Width, x => x.MapFrom(s => s.Width))
                .ForMember(d => d.Height, x => x.MapFrom(s => s.Height))
                .ForMember(d => d.DeepZoomTileSize, x => x.MapFrom(s => s.DeepZoomTileSize))
                .ForMember(d => d.DeepZoomOverlap, x => x.MapFrom(s => s.DeepZoomOverlap))
                .ForMember(d => d.Layers, x => x.MapFrom(s => s.Layers))
                .ForMember(d => d.ProcessingErrorMessage, x => x.MapFrom(s => s.ProcessingErrorMessage))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<MediaBlock, MediaBlockViewModel>()
                .ForMember(d => d.Attachment, x => x.MapFrom(s => s.Attachment))
                .ForMember(d => d.Image, x => x.MapFrom(s => s.Image))
                .ForMember(d => d.Video, x => x.MapFrom(s => s.Video))
                .ForMember(d => d.MediaType, x => x.MapFrom(s => s.MediaType))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<MediaBlockViewModel, MediaBlock>()
                .ForMember(d => d.Attachment, x => x.MapFrom(s => s.Attachment))
                .ForMember(d => d.Image, x => x.MapFrom(s => s.Image))
                .ForMember(d => d.Video, x => x.MapFrom(s => s.Video))
                .ForMember(d => d.MediaType, x => x.MapFrom(s => s.MediaType))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<Attachment, AttachmentViewModel>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<AttachmentViewModel, Attachment>()
                .ForMember(d => d.FileId, x => x.MapFrom(s => s.File.FileId != 0 ? s.File.FileId : (int?)null))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<Image, MediaImageViewModel>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForMember(d => d.AltText, x => x.MapFrom(s => s.AltText))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.Annotations, x => x.MapFrom(s => s.ImageAnnotations))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<MediaImageViewModel, Image>()
                .ForMember(d => d.FileId, x => x.MapFrom(s => s.File.FileId != 0 ? s.File.FileId : (int?)null))
                .ForMember(d => d.AltText, x => x.MapFrom(s => s.AltText))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.ImageAnnotations, x => x.MapFrom(s => s.Annotations))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<Video, MediaVideoViewModel>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<MediaVideoViewModel, Video>()
                .ForMember(d => d.FileId, x => x.MapFrom(s => s.File.FileId != 0 ? s.File.FileId : (int?)null))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<VideoFile, VideoFileViewModel>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForMember(d => d.Status, x => x.MapFrom(s => s.Status))
                .ForMember(d => d.ProcessingErrorMessage, x => x.MapFrom(s => s.ProcessingErrorMessage))
                .ForMember(d => d.CaptionsFile, x => x.MapFrom(s => s.CaptionsFile))
                .ForMember(d => d.TranscriptFile, x => x.MapFrom(s => s.TranscriptFile))
                .ForMember(d => d.AzureAssetOutputFilePath, x => x.MapFrom(s => s.AzureAssetOutputFilePath))
                .ForMember(d => d.LocatorUri, x => x.MapFrom(s => s.LocatorUri))
                .ForMember(d => d.EncodeJobName, x => x.MapFrom(s => s.EncodeJobName))
                .ForMember(d => d.DurationInMilliseconds, x => x.MapFrom(s => s.DurationInMilliseconds))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<VideoFileViewModel, VideoFile>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForMember(d => d.Status, x => x.MapFrom(s => s.Status))
                .ForMember(d => d.ProcessingErrorMessage, x => x.MapFrom(s => s.ProcessingErrorMessage))
                .ForMember(d => d.CaptionsFile, x => x.MapFrom(s => s.CaptionsFile))
                .ForMember(d => d.TranscriptFile, x => x.MapFrom(s => s.TranscriptFile))
                .ForMember(d => d.AzureAssetOutputFilePath, x => x.MapFrom(s => s.AzureAssetOutputFilePath))
                .ForMember(d => d.LocatorUri, x => x.MapFrom(s => s.LocatorUri))
                .ForMember(d => d.EncodeJobName, x => x.MapFrom(s => s.EncodeJobName))
                .ForMember(d => d.DurationInMilliseconds, x => x.MapFrom(s => s.DurationInMilliseconds))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<CaptionsFile, CaptionsFileViewModel>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<CaptionsFileViewModel, CaptionsFile>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<TranscriptFile, TranscriptFileViewModel>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<TranscriptFileViewModel, TranscriptFile>()
                .ForMember(d => d.File, x => x.MapFrom(s => s.File))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<ImageAnnotation, ImageAnnotationViewModel>()
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.Label, x => x.MapFrom(s => s.Label))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.PinXCoordinate, x => x.MapFrom(s => s.PinXCoordinate))
                .ForMember(d => d.PinYCoordinate, x => x.MapFrom(s => s.PinYCoordinate))
                .ForMember(d => d.Colour, x => x.MapFrom(s => s.Colour))
                .ForMember(d => d.ImageAnnotationMarks, x => x.MapFrom(s => s.ImageAnnotationMarks))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<ImageAnnotationViewModel, ImageAnnotation>()
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.Label, x => x.MapFrom(s => s.Label))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForMember(d => d.PinXCoordinate, x => x.MapFrom(s => s.PinXCoordinate))
                .ForMember(d => d.PinYCoordinate, x => x.MapFrom(s => s.PinYCoordinate))
                .ForMember(d => d.Colour, x => x.MapFrom(s => s.Colour))
                .ForMember(d => d.ImageAnnotationMarks, x => x.MapFrom(s => s.ImageAnnotationMarks))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<ImageAnnotationMark, ImageAnnotationMarkViewModel>()
                .ForMember(d => d.Type, x => x.MapFrom(s => s.Type))
                .ForMember(d => d.MarkLabel, x => x.MapFrom(s => s.MarkLabel))
                .ForMember(d => d.FreehandMarkShapeData, x => x.MapFrom(s => s.Type == ImageAnnotationMarkTypeEnum.Freehand ? JsonConvert.DeserializeObject<AnnotationMarkFreehandViewModel>(s.MarkShapeData) : null))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<ImageAnnotationMarkViewModel, ImageAnnotationMark>()
                .ForMember(d => d.Type, x => x.MapFrom(s => s.Type))
                .ForMember(d => d.MarkLabel, x => x.MapFrom(s => s.MarkLabel))
                .ForMember(d => d.MarkShapeData, x =>
                    x.MapFrom(s => JsonConvert.SerializeObject(s.FreehandMarkShapeData)))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<QuestionBlock, QuestionBlockViewModel>()
                .ForMember(vm => vm.Answers, x => x.MapFrom(q => q.Answers))
                .ForMember(vm => vm.QuestionBlockCollection, x => x.MapFrom(q => q.QuestionBlockCollection))
                .ForMember(vm => vm.FeedbackBlockCollection, x => x.MapFrom(q => q.FeedbackBlockCollection))
                .ForMember(vm => vm.QuestionType, x => x.MapFrom(q => (QuestionTypeEnum)q.QuestionType))
                .ForMember(vm => vm.AllowReveal, x => x.MapFrom(q => q.AllowReveal))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<QuestionBlockViewModel, QuestionBlock>()
                .ForMember(q => q.Answers, x => x.MapFrom(vm => vm.Answers))
                .ForMember(q => q.QuestionBlockCollection, x => x.MapFrom(vm => vm.QuestionBlockCollection))
                .ForMember(q => q.FeedbackBlockCollection, x => x.MapFrom(vm => vm.FeedbackBlockCollection))
                .ForMember(q => q.QuestionType, x => x.MapFrom(vm => vm.QuestionType))
                .ForMember(q => q.AllowReveal, x => x.MapFrom(vm => vm.AllowReveal))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<QuestionAnswer, QuestionAnswerViewModel>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.Status, x => x.MapFrom(s => s.Status))
                .ForMember(d => d.BlockCollection, x => x.MapFrom(s => s.BlockCollection))
                .ForMember(d => d.ImageAnnotationOrder, x => x.MapFrom(s => s.ImageAnnotationOrder))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<QuestionAnswerViewModel, QuestionAnswer>()
                .ForMember(d => d.Order, x => x.MapFrom(s => s.Order))
                .ForMember(d => d.Status, x => x.MapFrom(s => s.Status))
                .ForMember(d => d.BlockCollection, x => x.MapFrom(s => s.BlockCollection))
                .ForMember(d => d.ImageAnnotationOrder, x => x.MapFrom(s => s.ImageAnnotationOrder))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<AssessmentResourceVersion, AssessmentViewModel>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.AssessmentType, x => x.MapFrom(s => s.AssessmentType))
                .ForMember(d => d.AssessmentContent, x => x.MapFrom(s => s.AssessmentContent))
                .ForMember(d => d.MaximumAttempts, x => x.MapFrom(s => s.MaximumAttempts))
                .ForMember(d => d.PassMark, x => x.MapFrom(s => s.PassMark))
                .ForMember(d => d.AnswerInOrder, x => x.MapFrom(s => s.AnswerInOrder))
                .ForMember(d => d.EndGuidance, x => x.MapFrom(s => s.EndGuidance))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<AssessmentViewModel, AssessmentResourceVersion>()
                .ForMember(d => d.ResourceVersionId, x => x.MapFrom(s => s.ResourceVersionId))
                .ForMember(d => d.AssessmentType, x => x.MapFrom(s => s.AssessmentType))
                .ForMember(d => d.AssessmentContent, x => x.MapFrom(s => s.AssessmentContent))
                .ForMember(d => d.MaximumAttempts, x => x.MapFrom(s => s.MaximumAttempts))
                .ForMember(d => d.PassMark, x => x.MapFrom(s => s.PassMark))
                .ForMember(d => d.AnswerInOrder, x => x.MapFrom(s => s.AnswerInOrder))
                .ForMember(d => d.EndGuidance, x => x.MapFrom(s => s.EndGuidance))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<Page, PageViewModel>();
            this.CreateMap<PageSection, PageSectionViewModel>()
                .ForMember(d => d.SectionTemplateType, x => x.MapFrom(s => (SectionTemplateType)s.SectionTemplateTypeId))
                .ForMember(d => d.PageSectionDetail, x => x.MapFrom(s => s.PageSectionDetails.FirstOrDefault()));

            this.CreateMap<PageSectionViewModel, PageSection>()
               .ForMember(d => d.SectionTemplateTypeId, x => x.MapFrom(s => (int)s.SectionTemplateType));

            this.CreateMap<PageSectionDetail, PageSectionDetailViewModel>()
                .ForMember(d => d.PageSectionStatus, x => x.MapFrom(s => (PageSectionStatus)s.PageSectionStatusId))
                .ForMember(d => d.SectionLayoutType, x => x.MapFrom(s => (SectionLayoutType)s.SectionLayoutTypeId))
                .ForMember(d => d.DraftHidden, x => x.MapFrom(s => s.DraftHidden))
                .ForMember(d => d.DraftPosition, x => x.MapFrom(s => s.DraftPosition))
                .ForMember(d => d.DeletePending, x => x.MapFrom(s => s.DeletePending));

            this.CreateMap<PageSectionDetailViewModel, PageSectionDetail>()
                .ForMember(d => d.PageSectionStatusId, x => x.MapFrom(s => (int)s.PageSectionStatus))
                .ForMember(d => d.SectionLayoutTypeId, x => x.MapFrom(s => (int)s.SectionLayoutType));

            this.CreateMap<ImageCarouselBlock, ImageCarouselBlockViewModel>()
                .ForMember(d => d.Block, x => x.MapFrom(s => s.Block))
                .ForMember(d => d.ImageBlockCollection, x => x.MapFrom(s => s.ImageBlockCollection))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<ImageCarouselBlockViewModel, ImageCarouselBlock>()
                .ForMember(d => d.Block, x => x.MapFrom(s => s.Block))
                .ForMember(d => d.ImageBlockCollection, x => x.MapFrom(s => s.ImageBlockCollection))
                .ForMember(d => d.Description, x => x.MapFrom(s => s.Description))
                .ForAllOtherMembers(x => x.Ignore());

            this.CreateMap<ImageAsset, ImageAssetViewModel>();
            this.CreateMap<ImageAssetViewModel, ImageAsset>();
            this.CreateMap<VideoAsset, VideoAssetViewModel>();
            this.CreateMap<VideoAssetViewModel, VideoAsset>();

            this.CreateMap<ScormActivityViewModel, ScormActivity>()
                 .ForMember(d => d.Id, x => x.MapFrom(s => s.InstanceId))
                 .ForMember(d => d.CmiCoreLessonLocation, x => x.MapFrom(s => s.LessonLocation))
                 .ForMember(d => d.CmiCoreLessonStatus, x => x.MapFrom(s => s.LessonStatusId))
                 .ForMember(d => d.CmiCoreScoreRaw, x => x.MapFrom(s => s.ScoreRaw))
                 .ForMember(d => d.CmiCoreScoreMin, x => x.MapFrom(s => s.ScoreMin))
                 .ForMember(d => d.CmiCoreScoreMax, x => x.MapFrom(s => s.ScoreMax))
                 .ForMember(d => d.CmiCoreExit, x => x.MapFrom(s => s.Exit))
                 .ForMember(d => d.CmiCoreSessionTime, x => x.MapFrom(s => (s.SessionTime == null) ? string.Empty : s.SessionTime))
                 .ForMember(d => d.CmiSuspendData, x => x.MapFrom(s => s.SuspendData));

            this.CreateMap<ScormActivity, ScormActivityViewModel>()
               .ForMember(d => d.InstanceId, x => x.MapFrom(s => s.Id))
               .ForMember(d => d.LessonLocation, x => x.MapFrom(s => s.CmiCoreLessonLocation))
               .ForMember(d => d.LessonStatusId, x => x.MapFrom(s => s.CmiCoreLessonStatus))
               .ForMember(d => d.ScoreRaw, x => x.MapFrom(s => s.CmiCoreScoreRaw))
               .ForMember(d => d.ScoreMin, x => x.MapFrom(s => s.CmiCoreScoreMin))
               .ForMember(d => d.ScoreMax, x => x.MapFrom(s => s.CmiCoreScoreMax))
               .ForMember(d => d.Exit, x => x.MapFrom(s => s.CmiCoreExit))
               .ForMember(d => d.SessionTime, x => x.MapFrom(s => s.CmiCoreSessionTime))
               .ForMember(d => d.SuspendData, x => x.MapFrom(s => s.CmiSuspendData))
               .ForMember(d => d.DurationSeconds, x => x.MapFrom(s => s.DurationSeconds));

            this.CreateMap<ScormActivityInteractionViewModel, ScormActivityInteraction>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.ScormActivityInteractionId));

            this.CreateMap<ScormActivityInteraction, ScormActivityInteractionViewModel>()
                .ForMember(d => d.ScormActivityInteractionId, x => x.MapFrom(s => s.Id));

            this.CreateMap<ScormActivityInteractionCorrectResponse, ScormActivityInteractionCorrectResponseViewModel>();
            this.CreateMap<ScormActivityInteractionCorrectResponseViewModel, ScormActivityInteractionCorrectResponse>();

            this.CreateMap<ScormActivityInteractionObjectiveViewModel, ScormActivityInteractionObjective>();
            this.CreateMap<ScormActivityInteractionObjective, ScormActivityInteractionObjectiveViewModel>();

            this.CreateMap<ScormActivityObjectiveViewModel, ScormActivityObjective>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.ScormActivityObjectiveId));

            this.CreateMap<ScormActivityObjective, ScormActivityObjectiveViewModel>()
               .ForMember(d => d.ScormActivityObjectiveId, x => x.MapFrom(s => s.Id));

            this.CreateMap<ScormActivity, ScormUpdateResponseViewModel>()
                .ForMember(d => d.InstanceId, x => x.MapFrom(s => s.Id));
            this.CreateMap<ScormActivityInteraction, ScormUpdateInteractionViewModel>()
                .ForMember(d => d.ScormActivityInteractionId, x => x.MapFrom(s => s.Id))
                .ForMember(d => d.InteractionId, x => x.MapFrom(s => s.Id));

            this.CreateMap<ScormActivityObjective, ScormUpdateObjectiveViewModel>()
               .ForMember(d => d.ScormActivityObjectiveId, x => x.MapFrom(s => s.Id))
               .ForMember(d => d.ObjectiveId, x => x.MapFrom(s => s.Id));

            this.CreateMap<UserBookmark, UserBookmarkViewModel>();
            this.CreateMap<UserBookmarkViewModel, UserBookmark>();

            this.CreateMap<CreateMediaResourceActivityViewModel, MediaResourceActivity>();

            this.CreateMap<ReportCreateModel, Report>();

            this.CreateMap<Report, ReportModel>();
            this.CreateMap<ReportModel, Report>();

            this.CreateMap<ReportPage, ReportPageModel>();
            this.CreateMap<ReportPageModel, ReportPage>();
            this.CreateMap<ReportModel, ResponseModel>();
            this.CreateMap<ReportStatusUpdateModel, ResponseModel>();
            this.CreateMap<Client, ClientModel>();

            this.CreateMap<Report, ReportStatusModel>()
                .ForMember(d => d.Id, x => x.MapFrom(s => s.ReportStatusId))
                .ForMember(d => d.Status, x => x.MapFrom(s => Enum.GetName(typeof(LearningHub.Nhs.Models.Enums.Report.Status), s.ReportStatusId)))
                .ForAllOtherMembers(d => d.Ignore());

            this.CreateMap<SearchActionResourceModel, SearchFeedbackPayloadModel>()
                .ForMember(d => d.HitNumber, x => x.MapFrom(s => s.ItemIndex + 1))
                .ForMember(d => d.ClickTargetUrl, x => x.MapFrom(s => s.ResourceReferenceId.ToString()))
                .ForPath(d => d.SearchSignal.SearchId, x => x.MapFrom(s => s.SearchId))
                .ForPath(d => d.SearchSignal.Query, x => x.MapFrom(s => s.Query))
                .ForPath(d => d.SearchSignal.UserQuery, x => x.MapFrom(s => s.UserQuery))
                .ForPath(d => d.SearchSignal.TimeOfSearch, x => x.MapFrom(s => s.TimeOfSearch))
                .ForPath(d => d.SearchSignal.Stats.TotalHits, x => x.MapFrom(s => s.TotalNumberOfHits));

            this.CreateMap<SearchActionCatalogueModel, SearchFeedbackPayloadModel>()
                .ForMember(d => d.HitNumber, x => x.MapFrom(s => s.ItemIndex + 1))
                .ForMember(d => d.ClickTargetUrl, x => x.MapFrom(s => s.CatalogueId.ToString()))
                .ForPath(d => d.SearchSignal.SearchId, x => x.MapFrom(s => s.SearchId))
                .ForPath(d => d.SearchSignal.Query, x => x.MapFrom(s => s.Query))
                .ForPath(d => d.SearchSignal.UserQuery, x => x.MapFrom(s => s.UserQuery))
                .ForPath(d => d.SearchSignal.TimeOfSearch, x => x.MapFrom(s => s.TimeOfSearch))
                .ForPath(d => d.SearchSignal.Stats.TotalHits, x => x.MapFrom(s => s.TotalNumberOfHits));

            this.CreateMap<InternalSystem, InternalSystemViewModel>();

            this.CreateMap<ProviderViewModel, Provider>();
            this.CreateMap<Provider, ProviderViewModel>();
            this.CreateMap<UserProvider, UserProviderViewModel>();
            this.CreateMap<Entities.Resource.ResourceVersionProvider, ResourceVersionProviderViewModel>();
            this.CreateMap<ResourceVersionProviderViewModel, Entities.Resource.ResourceVersionProvider>();
        }
    }
}
