namespace LearningHub.Nhs.Models.Binders
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using LearningHub.Nhs.Models.Resource.Contribute;
    using Microsoft.AspNetCore.Mvc.Formatters;
    using Microsoft.AspNetCore.Mvc.Infrastructure;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

    /// <summary>
    /// Sanitized Html Model Binder.
    /// </summary>
    public class SanitizedHtmlFormBodyModelBinder : IModelBinder
    {
        private readonly BodyModelBinder defaultBinder;

        /// <summary>
        /// Initializes a new instance of the <see cref="SanitizedHtmlFormBodyModelBinder"/> class.
        /// </summary>
        /// <param name="formatters">The Formatters.</param>
        /// <param name="readerFactory">The ReaderFactory.</param>
        public SanitizedHtmlFormBodyModelBinder(IList<IInputFormatter> formatters, IHttpRequestStreamReaderFactory readerFactory)
        {
            this.defaultBinder = new BodyModelBinder(formatters, readerFactory);
        }

        /// <summary>
        /// Binding Model Task.
        /// </summary>
        /// <param name="bindingContext">Model Binding Context.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            await this.defaultBinder.BindModelAsync(bindingContext);

            if (bindingContext.Result.IsModelSet)
            {
                if (bindingContext.Result.Model is ResourceDetailViewModel resource && resource != null)
                {
                    this.SetBindingContext(bindingContext, resource, "Description", resource.Description);
                }

                if (bindingContext.Result.Model is ArticleUpdateRequestViewModel articleUpdate && articleUpdate != null)
                {
                    this.SetBindingContext(bindingContext, articleUpdate, "Description", articleUpdate.Description);
                }
            }
        }

        private void SetBindingContext(ModelBindingContext bindingContext, object model, string propName, string propValue)
        {
            try
            {
                var propertyInfo = model.GetType().GetProperty(propName);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(model, SanitizeHtmlUtility.Sanitize(propValue), null);
                }

                bindingContext.Result = ModelBindingResult.Success(model);
            }
            catch
            {
                bindingContext.Result = ModelBindingResult.Failed();
            }
        }
    }
}