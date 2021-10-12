using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Region search Query
    /// </summary>
    public class RegionsClientSearchQuery : IRegionsClientSearchQuery
    {
        private readonly RegionsClient _regionsClient;
        internal RegionsClientSearchQuery(RegionsClient regionsClient)
        {
            _regionsClient = regionsClient;
        }

        /// <inheritdoc/>
        public IRegionsClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _regionsClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IRegionsClientSearchQuery WithSort(RegionSortField orderBy)
        {
            _regionsClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IRegionsClientSearchQuery WithSortDescending(RegionSortField orderBy)
        {
            _regionsClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Region>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _regionsClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Region> ExecuteSearch(bool ignoreCache = false)
        {
            return _regionsClient.ExecuteSearch(ignoreCache);
        }
    }
}