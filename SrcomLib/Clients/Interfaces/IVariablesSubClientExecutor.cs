using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for finalizing Variable sub-query requests
    /// </summary>
    public interface IVariablesSubClientExecutor
    {
        /// <summary>
        /// Gets the specified Variable data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Variable>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Variable data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        IReadOnlyList<Variable> GetList(bool ignoreCache = false);
    }
}