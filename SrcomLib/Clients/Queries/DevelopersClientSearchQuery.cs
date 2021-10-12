using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Developer search Query
    /// </summary>
    public class DevelopersClientSearchQuery : IDevelopersClientSearchQuery
    {
        private readonly DevelopersClient _developersClient;
        internal DevelopersClientSearchQuery(DevelopersClient developersClient)
        {
            _developersClient = developersClient;
        }

        /// <inheritdoc/>
        public IDevelopersClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _developersClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IDevelopersClientSearchQuery WithSort(DeveloperSortField orderBy)
        {
            _developersClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IDevelopersClientSearchQuery WithSortDescending(DeveloperSortField orderBy)
        {
            _developersClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Developer>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _developersClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Developer> ExecuteSearch(bool ignoreCache = false)
        {
            return _developersClient.ExecuteSearch(ignoreCache);
        }
    }
}