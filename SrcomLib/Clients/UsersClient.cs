using api = SrcomLib.ApiObjects;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.Clients.Queries;
using SrcomLib.Clients.Interfaces;

namespace SrcomLib.Clients
{
    /// <summary>
    /// Class for starting building a User request
    /// </summary>
    public class UsersClient : IUsersClient
    {
        private readonly BaseApiObjectClient<api.User, User> _baseClient;
        private readonly SrcomClient _client;
        private readonly uint _maxSearchRecords;
        private string _id;
        internal UsersClient(SrcomClient client, uint maxSearchRecords)
        {
            _client = client;
            _maxSearchRecords = maxSearchRecords;
            _id = string.Empty;
            _baseClient = new BaseApiObjectClient<api.User, User>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IUsersClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IUsersClientIdQuery WithId(string id)
        {
            _id = id;
            _baseClient.WithId(id);
            return new UsersClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IPersonalBestsClient PersonalBests()
        {
            return new PersonalBestsClient(_client, _maxSearchRecords, ApiObject.User, _id);
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSearch(UserSearchField field, string searchValue)
        {
            _baseClient.WithSearch((SearchField)field, searchValue);
            return new UsersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSearch(IDictionary<UserSearchField, string> searchParameters)
        {
            _baseClient.WithSearch(searchParameters.ToBaseSearchDictionary());
            return new UsersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new UsersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSort(UserSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new UsersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IUsersClientSearchQuery WithSortDescending(UserSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new UsersClientSearchQuery(this);
        }

        internal async Task<User> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<User>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        internal User Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<User> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}