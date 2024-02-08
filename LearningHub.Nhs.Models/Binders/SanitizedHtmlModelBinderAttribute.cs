namespace LearningHub.Nhs.Models.Binders
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Sanitized Html Model Binder.
    /// </summary>
    public class SanitizedHtmlModelBinderAttribute : ModelBinderAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SanitizedHtmlModelBinderAttribute"/> class.
        /// </summary>
        public SanitizedHtmlModelBinderAttribute()
            : base(typeof(SanitizedHtmlFormDataModelBinder))
        {
        }
    }
}