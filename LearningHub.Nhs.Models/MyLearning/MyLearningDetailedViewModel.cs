namespace LearningHub.Nhs.Models.MyLearning
{
    using System.Collections.Generic;

    /// <summary>
    /// The My Learning detailed view model.
    /// </summary>
    public class MyLearningDetailedViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyLearningDetailedViewModel"/> class.
        /// </summary>
        public MyLearningDetailedViewModel()
        {
            this.Activities = new List<MyLearningDetailedItemViewModel>();
        }

        /// <summary>
        /// Gets or sets the total count of activities.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the activities.
        /// </summary>
        public List<MyLearningDetailedItemViewModel> Activities { get; set; }
    }
}
