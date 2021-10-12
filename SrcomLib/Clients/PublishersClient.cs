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
    /// Class for starting building a Publisher request
    /// </summary>
    public class PublishersClient : IPublishersClient
    {
        private readonly BaseApiObjectClient<api.Publisher, Publisher> _baseClient;
        internal PublishersClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Publisher, Publisher>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IPublishersClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IPublishersClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new PublishersClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IPublishersClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new PublishersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IPublishersClientSearchQuery WithSort(PublisherSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new PublishersClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IPublishersClientSearchQuery WithSortDescending(PublisherSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new PublishersClientSearchQuery(this);
        }

        internal async Task<Publisher> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Publisher>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        internal Publisher Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Publisher> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}