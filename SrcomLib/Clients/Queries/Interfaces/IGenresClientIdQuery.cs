using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for submitting a Genre Id Query
    /// </summary>
    public interface IGenresClientIdQuery
    {
        /// <summary>
        /// Gets the specified Genre data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Task<Genre> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Genre data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Genre Get(bool ignoreCache = false);
    }
}