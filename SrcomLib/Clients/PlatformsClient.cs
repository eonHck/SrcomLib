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
    /// Class for starting building a Platform request
    /// </summary>
    public class PlatformsClient : IPlatformsClient
    {
        private readonly BaseApiObjectClient<api.Platform, Platform> _baseClient;
        internal PlatformsClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Platform, Platform>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IPlatformsClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IPlatformsClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new PlatformsClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IPlatformsClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new PlatformsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IPlatformsClientSearchQuery WithSort(PlatformSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new PlatformsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IPlatformsClientSearchQuery WithSortDescending(PlatformSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new PlatformsClientSearchQuery(this);
        }

        internal async Task<Platform> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Platform>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        internal Platform Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Platform> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}