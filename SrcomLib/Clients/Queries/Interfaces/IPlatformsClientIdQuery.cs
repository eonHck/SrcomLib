using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for submitting a Platform Id Query
    /// </summary>
    public interface IPlatformsClientIdQuery
    {
        /// <summary>
        /// Gets the specified Platform data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Task<Platform> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Platform data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Platform Get(bool ignoreCache = false);
    }
}