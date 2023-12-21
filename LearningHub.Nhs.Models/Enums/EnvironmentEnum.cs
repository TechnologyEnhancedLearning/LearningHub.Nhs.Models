// <copyright file="EnvironmentEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The environment enum.
    /// </summary>
    public enum EnvironmentEnum
    {
        /// <summary>
        /// The local environment.
        /// </summary>
        Local = 1,

        /// <summary>
        /// The development environment.
        /// </summary>
        Development,

        /// <summary>
        /// The test environment.
        /// </summary>
        Test,

        /// <summary>
        /// The uat environment.
        /// </summary>
        UAT,

        /// <summary>
        /// The staging environment.
        /// </summary>
        Staging,

        /// <summary>
        /// The production environment.
        /// </summary>
        Production,

        /// <summary>
        /// The pathology development environment.
        /// </summary>
        DevelopmentPath,
    }
}