using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a User Search Query
    /// </summary>
    public class UsersClientSearchQuery : IUsersClientSearchQuery
    {
        private readonly UsersClient _usersClient;
        internal UsersClientSearchQuery(UsersClient usersClient)
        {
            _usersClient = usersClient;
        }
        
        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSearch(UserSearchField field, string searchValue)
        {
            _usersClient.WithSearch(field, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSearch(IDictionary<UserSearchField, string> searchParameters)
        {
            _usersClient.WithSearch(searchParameters);
            return this;
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _usersClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSort(UserSortField orderBy)
        {
            _usersClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSortDescending(UserSortField orderBy)
        {
            _usersClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<User>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _usersClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<User> ExecuteSearch(bool ignoreCache = false)
        {
            return _usersClient.ExecuteSearch(ignoreCache);
        }
    }
}