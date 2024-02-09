namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Content;
    using LearningHub.Nhs.Models.Entities.Resource.Blocks;

    /// <summary>
    /// The file.
    /// </summary>
    public partial class File : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        public File()
        {
            this.ArticleResourceVersionFile = new HashSet<ArticleResourceVersionFile>();
            this.GenericFileResourceVersion = new HashSet<GenericFileResourceVersion>();
            this.ImageResourceVersion = new HashSet<ImageResourceVersion>();
            this.VideoResourceVersion = new HashSet<VideoResourceVersion>();
            this.AudioResourceVersion = new HashSet<AudioResourceVersion>();
            this.WholeSlideImages = new HashSet<WholeSlideImage>();
            this.Attachments = new HashSet<Attachment>();
            this.Images = new HashSet<Image>();
            this.Videos = new HashSet<Video>();
            this.ImageAssets = new HashSet<ImageAsset>();
            this.VideoAssettClosedCaptionsFiles = new HashSet<VideoAsset>();
            this.VideoAssettThumbnailImageFiles = new HashSet<VideoAsset>();
            this.VideoAssettTranscriptFiles = new HashSet<VideoAsset>();
            this.VideoAssettVideoFiles = new HashSet<VideoAsset>();
        }

        /// <summary>
        /// Gets or sets the file type id..
        /// </summary>
        public int FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets the file chunk detail id..
        /// </summary>
        public int? FileChunkDetailId { get; set; }

        /// <summary>
        /// Gets or sets the file name..
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the file path..
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file size kb..
        /// </summary>
        public int? FileSizeKb { get; set; }

        /// <summary>
        /// Gets or sets the file type..
        /// </summary>
        public virtual FileType FileType { get; set; }

        /// <summary>
        /// Gets or sets the article resource version file..
        /// </summary>
        public virtual ICollection<ArticleResourceVersionFile> ArticleResourceVersionFile { get; set; }

        /// <summary>
        /// Gets or sets the generic file resource version..
        /// </summary>
        public virtual ICollection<GenericFileResourceVersion> GenericFileResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the image resource version..
        /// </summary>
        public virtual ICollection<ImageResourceVersion> ImageResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the video resource version..
        /// </summary>
        public virtual ICollection<VideoResourceVersion> VideoResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the audio resource version..
        /// </summary>
        public virtual ICollection<AudioResourceVersion> AudioResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the Partial File.
        /// </summary>
        public virtual PartialFile PartialFile { get; set; }

        /// <summary>
        /// Gets or sets the Whole Slide Image File.
        /// </summary>
        public virtual WholeSlideImageFile WholeSlideImageFile { get; set; }

        /// <summary>
        /// Gets or sets the Video File.
        /// </summary>
        public virtual VideoFile VideoFile { get; set; }

        /// <summary>
        /// Gets or sets the Captions File.
        /// </summary>
        public virtual CaptionsFile CaptionsFile { get; set; }

        /// <summary>
        /// Gets or sets the Transcript File.
        /// </summary>
        public virtual TranscriptFile TranscriptFile { get; set; }

        /// <summary>
        /// Gets or sets the Whole Slide Images.
        /// </summary>
        public virtual ICollection<WholeSlideImage> WholeSlideImages { get; set; }

        /// <summary>
        /// Gets or sets the Attachments.
        /// </summary>
        public virtual ICollection<Attachment> Attachments { get; set; }

        /// <summary>
        /// Gets or sets the Images.
        /// </summary>
        public virtual ICollection<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the Videos.
        /// </summary>
        public virtual ICollection<Video> Videos { get; set; }

        /// <summary>
        /// Gets or sets the ImageAssetts.
        /// </summary>
        public virtual ICollection<ImageAsset> ImageAssets { get; set; }

        /// <summary>
        /// Gets or sets the VideoAssettClosedCaptionsFiles.
        /// </summary>
        public virtual ICollection<VideoAsset> VideoAssettClosedCaptionsFiles { get; set; }

        /// <summary>
        /// Gets or sets the VideoAssettThumbnailImageFiles.
        /// </summary>
        public virtual ICollection<VideoAsset> VideoAssettThumbnailImageFiles { get; set; }

        /// <summary>
        /// Gets or sets the VideoAssettTranscriptFiles.
        /// </summary>
        public virtual ICollection<VideoAsset> VideoAssettTranscriptFiles { get; set; }

        /// <summary>
        /// Gets or sets the VideoAssettVideoFiles.
        /// </summary>
        public virtual ICollection<VideoAsset> VideoAssettVideoFiles { get; set; }
    }
}
