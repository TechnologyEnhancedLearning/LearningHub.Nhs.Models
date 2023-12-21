// <copyright file="EventValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System;
    using FluentValidation;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The event validator.
    /// </summary>
    public class EventValidator : AbstractValidator<Entities.Analytics.Event>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventValidator"/> class.
        /// </summary>
        public EventValidator()
        {
            this.RuleFor(x => (int)x.EventTypeEnum)
            .NotEqual(0)
            .WithMessage($"Event Type is mandatory");

            this.RuleFor(x => x.JsonData).Custom((jsondata, context) =>
            {
                if (!IsValidJSON(jsondata))
                {
                    context.AddFailure("String must be valid json");
                }
            });
        }

        /// <summary>
        /// Validate the string if its a json.
        /// </summary>
        /// <param name="json">json string.</param>
        /// <returns>boolean.</returns>
        private static bool IsValidJSON(string json)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(json))
                {
                    return true;
                }

                JToken token = JObject.Parse(json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
