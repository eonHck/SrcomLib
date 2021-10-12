using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for submitting a Developer Id Query
    /// </summary>
    public interface IDevelopersClientIdQuery
    {
        /// <summary>
        /// Gets the specified Developer data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Task<Developer> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Developer data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Developer Get(bool ignoreCache = false);
    }
}