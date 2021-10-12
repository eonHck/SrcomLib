using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for submitting an Engine Id Query
    /// </summary>
    public interface IEnginesClientIdQuery
    {
        /// <summary>
        /// Gets the specified Engine data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Engine> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Engine data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Engine Get(bool ignoreCache = false);
    }
}