using SrcomLib.Clients.Interfaces;
using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a User Id Query
    /// </summary>
    public class UsersClientIdQuery : IUsersClientIdQuery
    {
        private readonly UsersClient _usersClient;
        internal UsersClientIdQuery(UsersClient usersClient)
        {
            _usersClient = usersClient;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient PersonalBests()
        {
            return _usersClient.PersonalBests();
        }

        /// <inheritdoc/>
        public async Task<User> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _usersClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public User Get(bool ignoreCache = false)
        {
            return _usersClient.Get(ignoreCache);
        }

    }
}