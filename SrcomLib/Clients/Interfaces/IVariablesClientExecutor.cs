using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for finalizing Variable requests
    /// </summary>
    public interface IVariablesClientExecutor
    {
        /// <summary>
        /// Gets the specified Variable data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<Variable> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Variable data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        Variable Get(bool ignoreCache = false);
    }
}