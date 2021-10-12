using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for submitting a Region Id Query
    /// </summary>
    public interface IRegionsClientIdQuery
    {
        /// <summary>
        /// Gets the specified Region data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Task<Region> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Region data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Region Get(bool ignoreCache = false);
    }
}