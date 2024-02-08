namespace LearningHub.Nhs.Models.AzureQueue
{
    /// <summary>
    /// The BaseQueueMessage.
    /// </summary>
    public class BaseQueueMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseQueueMessage"/> class.
        /// </summary>
        /// <param name="route">route.</param>
        public BaseQueueMessage(string route)
        {
            this.Route = route;
        }

        /// <summary>
        /// Gets or sets the Route.
        /// </summary>
        public string Route { get; set; }
    }
}
