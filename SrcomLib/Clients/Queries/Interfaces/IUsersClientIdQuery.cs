using SrcomLib.Clients.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries.Interfaces
{
    /// <summary>
    /// Interface for building and submitting a User Id Query
    /// </summary>
    public interface IUsersClientIdQuery
    {
        /// <summary>
        /// Get the Personal Bests associated with the selected User Id
        /// </summary>
        /// <returns></returns>
        IPersonalBestsClient PersonalBests();

        /// <summary>
        /// Gets the specified User data asynchronously
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<User> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified User data
        /// </summary>
        /// <param name="ignoreCache"></param>
        /// <returns></returns>
        User Get(bool ignoreCache = false);
    }
}