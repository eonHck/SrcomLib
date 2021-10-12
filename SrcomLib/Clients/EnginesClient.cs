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
    /// <summary>
    /// Class for starting building an Engine request
    /// </summary>
    public class EnginesClient : IEnginesClient
    {
        private readonly BaseApiObjectClient<api.Engine, Engine> _baseClient;
        internal EnginesClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Engine, Engine>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IEnginesClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IEnginesClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new EnginesClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IEnginesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new EnginesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IEnginesClientSearchQuery WithSort(EngineSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new EnginesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IEnginesClientSearchQuery WithSortDescending(EngineSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new EnginesClientSearchQuery(this);
        }

        internal async Task<Engine> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Engine>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        internal Engine Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Engine> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}