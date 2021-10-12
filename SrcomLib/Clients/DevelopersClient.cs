using api = SrcomLib.ApiObjects;
using SrcomLib.ResponseObjects;
using SrcomLib.Clients.Interfaces;
using SrcomLib.Clients.Queries.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using SrcomLib.Clients.Queries;

namespace SrcomLib.Clients
{
    public class DevelopersClient : IDevelopersClient
    {
        private readonly BaseApiObjectClient<api.Developer, Developer> _baseClient;
        internal DevelopersClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Developer, Developer>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IDevelopersClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IDevelopersClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new DevelopersClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IDevelopersClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new DevelopersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IDevelopersClientSearchQuery WithSort(DeveloperSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new DevelopersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IDevelopersClientSearchQuery WithSortDescending(DeveloperSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new DevelopersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        internal async Task<Developer> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Developer>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        internal Developer Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Developer> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}