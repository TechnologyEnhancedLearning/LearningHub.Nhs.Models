namespace LearningHub.Nhs.Models.Binders
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    /// <summary>
    /// Sanitized Html Model Binder.
    /// </summary>
    public class SanitizedHtmlFormDataModelBinder : IModelBinder
    {
        /// <summary>
        /// Binding Model Task.
        /// </summary>
        /// <param name="bindingContext">Model Binding Context.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            var value = valueProviderResult.FirstValue;

            try
            {
                var model = SanitizeHtmlUtility.Sanitize(value);
                bindingContext.Result = ModelBindingResult.Success(model);
            }
            catch
            {
                bindingContext.Result = ModelBindingResult.Failed();
            }

            await Task.Yield();
        }
    }
}