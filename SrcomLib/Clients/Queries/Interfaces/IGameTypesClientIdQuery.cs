using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for submitting a Game Type Id Query
    /// </summary>
    public interface IGameTypesClientIdQuery
    {
        /// <summary>
        /// Gets the specified Developer data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        Task<GameType> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Developer data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        GameType Get(bool ignoreCache = false);
    }
}