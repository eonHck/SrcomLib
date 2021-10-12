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
    /// Class for starting building a Series request
    /// </summary>
    public class SeriesClient : ISeriesClient
    {
        private readonly BaseApiObjectClient<api.Series, Series> _baseClient;
        private readonly SrcomClient _client;
        private readonly uint _maxSearchRecords;
        private string _id;

        internal SeriesClient(SrcomClient client, uint maxSearchRecords)
        {
            _client = client;
            _maxSearchRecords = maxSearchRecords;
            _baseClient = new BaseApiObjectClient<api.Series, Series>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal ISeriesClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public ISeriesClientIdQuery WithId(string id)
        {
            _id = id;
            _baseClient.WithId(id);
            return new SeriesClientIdQuery(this);
        }

        internal IGamesSubClientSearchQuery Games()
        {
            return new GamesClient(_client, _maxSearchRecords)
                .GetSubClientSearchQuery(ApiObject.Series, _id);
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSearch(SeriesSearchField field, string searchValue)
        {
            _baseClient.WithSearch((SearchField)field, searchValue);
            return new SeriesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSearch(IDictionary<SeriesSearchField, string> searchParameters)
        {
            _baseClient.WithSearch(searchParameters.ToBaseSearchDictionary());
            return new SeriesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new SeriesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public ISeriesClient IncludeEmbed(SeriesEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSort(SeriesSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new SeriesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSortDescending(SeriesSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new SeriesClientSearchQuery(this);
        }

        internal async Task<Series> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Series>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        internal Series Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Series> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}