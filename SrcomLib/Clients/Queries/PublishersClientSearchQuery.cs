using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Publisher search Query
    /// </summary>
    public class PublishersClientSearchQuery : IPublishersClientSearchQuery
    {
        private readonly PublishersClient _publishersClient;
        internal PublishersClientSearchQuery(PublishersClient publishersClient)
        {
            _publishersClient = publishersClient;
        }

        /// <inheritdoc/>
        public IPublishersClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _publishersClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IPublishersClientSearchQuery WithSort(PublisherSortField orderBy)
        {
            _publishersClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IPublishersClientSearchQuery WithSortDescending(PublisherSortField orderBy)
        {
            _publishersClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Publisher>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _publishersClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Publisher> ExecuteSearch(bool ignoreCache = false)
        {
            return _publishersClient.ExecuteSearch(ignoreCache);
        }
    }
}