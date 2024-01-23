﻿// <copyright file="ResourceFileParamsModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Migration.ResourceModels
{
    /// <summary>
    /// Provides the parameters required for creating a resource file.
    /// </summary>
    public class ResourceFileParamsModel
    {
        /// <summary>
        /// Gets or sets the FileTypeId.
        /// </summary>
        public int FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets the FileName.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the FilePath.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the FileSizeKb.
        /// </summary>
        public int FileSizeKb { get; set; }
    }
}
