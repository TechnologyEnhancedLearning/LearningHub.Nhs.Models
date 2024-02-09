namespace LearningHub.Nhs.Models.Resource.Activity
{
    /// <summary>
    /// The CreateResourceActivityAndInteractionViewModel. Wrapper model for storing both a CreateResourceActivityViewModel and a CreateMediaResourceActivityInteractionViewModel at the same time.
    /// </summary>
    public class CreateResourceActivityAndInteractionViewModel
    {
        /// <summary>
        /// Gets or sets the CreateResourceActivityViewModel.
        /// </summary>
        public CreateResourceActivityViewModel CreateResourceActivityViewModel { get; set; }

        /// <summary>
        /// Gets or sets the CreateMediaResourceActivityInteractionViewModel.
        /// </summary>
        public CreateMediaResourceActivityInteractionViewModel CreateMediaResourceActivityInteractionViewModel { get; set; }
    }
}
