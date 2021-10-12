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
    /// Class for starting building a Region request
    /// </summary>
    public class RegionsClient : IRegionsClient
    {
        private readonly BaseApiObjectClient<api.Region, Region> _baseClient;
        internal RegionsClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Region, Region>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IRegionsClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IRegionsClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new RegionsClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IRegionsClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new RegionsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IRegionsClientSearchQuery WithSort(RegionSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new RegionsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IRegionsClientSearchQuery WithSortDescending(RegionSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new RegionsClientSearchQuery(this);
        }

        internal async Task<Region> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Region>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        internal Region Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Region> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}