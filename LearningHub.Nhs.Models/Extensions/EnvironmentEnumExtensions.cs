// <copyright file="EnvironmentEnumExtensions.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Extensions
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The environment enum extensions.
    /// </summary>
    public static class EnvironmentEnumExtensions
    {
        /// <summary>
        /// The get current user id.
        /// </summary>
        /// <param name="environment">
        /// The environment.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetAbbreviation(this EnvironmentEnum environment)
        {
            switch (environment)
            {
                case EnvironmentEnum.Local:
                    return "lcl";
                case EnvironmentEnum.Development:
                    return "dev";
                case EnvironmentEnum.DevelopmentPath:
                    return "dvp";
                case EnvironmentEnum.Test:
                    return "tst";
                case EnvironmentEnum.UAT:
                    return "uat";
                case EnvironmentEnum.Staging:
                    return "stg";
                case EnvironmentEnum.Production:
                    return "prd";
                default:
                    return "lcl";
            }
        }
    }
}
