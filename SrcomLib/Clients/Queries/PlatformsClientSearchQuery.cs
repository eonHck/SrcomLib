using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Platform search Query
    /// </summary>
    public class PlatformsClientSearchQuery : IPlatformsClientSearchQuery
    {
        private readonly PlatformsClient _platformsClient;
        internal PlatformsClientSearchQuery(PlatformsClient platformsClient)
        {
            _platformsClient = platformsClient;
        }

        /// <inheritdoc/>
        public IPlatformsClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _platformsClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IPlatformsClientSearchQuery WithSort(PlatformSortField orderBy)
        {
            _platformsClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IPlatformsClientSearchQuery WithSortDescending(PlatformSortField orderBy)
        {
            _platformsClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Platform>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _platformsClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Platform> ExecuteSearch(bool ignoreCache = false)
        {
            return _platformsClient.ExecuteSearch(ignoreCache);
        }
    }
}