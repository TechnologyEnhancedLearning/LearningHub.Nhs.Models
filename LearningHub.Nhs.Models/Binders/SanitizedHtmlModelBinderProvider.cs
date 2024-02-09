namespace LearningHub.Nhs.Models.Binders
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Resource.Contribute;
    using Microsoft.AspNetCore.Mvc.Formatters;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    /// <summary>
    /// The Sanitized Html Model Binder Provider.
    /// </summary>
    public class SanitizedHtmlModelBinderProvider : IModelBinderProvider
    {
        private readonly IList<IInputFormatter> formatters;
        private readonly IHttpRequestStreamReaderFactory readerFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="SanitizedHtmlModelBinderProvider"/> class.
        /// </summary>
        /// <param name="formatters">The Formatters.</param>
        /// <param name="readerFactory">The ReaderFactory.</param>
        public SanitizedHtmlModelBinderProvider(IList<IInputFormatter> formatters, IHttpRequestStreamReaderFactory readerFactory)
        {
            this.formatters = formatters;
            this.readerFactory = readerFactory;
        }

        /// <summary>
        /// Get Model Binder.
        /// </summary>
        /// <param name="context">The Model Binder Provider Context.</param>
        /// <returns>The IModelBinder.</returns>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(ResourceDetailViewModel)
                || context.Metadata.ModelType == typeof(ArticleUpdateRequestViewModel))
            {
                return new SanitizedHtmlFormBodyModelBinder(this.formatters, this.readerFactory);
            }

            return null;
        }
    }
}