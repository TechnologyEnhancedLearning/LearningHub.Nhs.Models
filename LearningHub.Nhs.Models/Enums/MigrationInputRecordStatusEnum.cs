// <copyright file="MigrationInputRecordStatusEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The migration input record status enum.
    /// </summary>
    public enum MigrationInputRecordStatusEnum
    {
        /// <summary>
        /// This status means the MigrationInputRecord has been created but no processing has been carried out on it yet.
        /// </summary>
        Created,

        /// <summary>
        /// This status means the MigrationInputRecord was validated but one or more validation errors were found. There may also be one or more validation warnings. This status prevents the record being processed any further.
        /// </summary>
        ValidationFailed,

        /// <summary>
        /// This status means the MigrationInputRecord was validated and no errors were found. There may still be one or more validation warnings but the record can still be moved on to the next stage.
        /// </summary>
        ValidationComplete,

        /// <summary>
        /// This status means the draft resource creation in LH failed. This status prevents the record being processed any further.
        /// </summary>
        LHMetadataCreationFailed,

        /// <summary>
        /// This status means the draft resource creation in LH was successful.
        /// </summary>
        LHMetadataCreationComplete,

        /// <summary>
        /// This status means the resource has been added to the Azure publish queue for publishing but has not yet been published.
        /// </summary>
        LHQueuedForPublish,

        /// <summary>
        /// This status means the attempt to publish the resource failed.
        /// </summary>
        LHPublishFailed,

        /// <summary>
        /// This status means the resource was successfully published.
        /// </summary>
        LHPublishComplete,

        /// <summary>
        /// This status means the migration that the record belongs to was abandoned. (Not yet implemented)
        /// </summary>
        Abandoned,
    }
}
