namespace LearningHub.Nhs.Models.Common.Interfaces
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// The CachingService interface.
    /// </summary>
    /// <typeparam name="T">Input type.</typeparam>
    public interface ICachingService<T>
    {
        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<T> GetAsync(string key, Func<Task<T>> action);

        /// <summary>
        /// The remove async.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task RemoveAsync(string key);
    }
}