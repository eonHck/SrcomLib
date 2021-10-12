using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Interfaces
{    /// <summary>
     /// Interface for submitting a Guest request
     /// </summary>
    public interface IGuestsClientExecutor
    {
        /// <summary>
        /// Gets the specified Guest data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Task<Guest> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Guest data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Guest Get(bool ignoreCache = false);
    }
}