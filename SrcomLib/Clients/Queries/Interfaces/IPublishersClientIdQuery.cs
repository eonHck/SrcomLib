using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for submitting a Publisher Id Query
    /// </summary>
    public interface IPublishersClientIdQuery
    {
        /// <summary>
        /// Gets the specified Publisher data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Task<Publisher> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Publisher data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Publisher Get(bool ignoreCache = false);
    }
}