using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Interface for building and submitting a Series Serach Query
    /// </summary>
    public class SeriesClientSearchQuery : ISeriesClientSearchQuery
    {
        private readonly SeriesClient _seriessClient;
        internal SeriesClientSearchQuery(SeriesClient seriessClient)
        {
            _seriessClient = seriessClient;
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSearch(SeriesSearchField field, string searchValue)
        {
            _seriessClient.WithSearch(field, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSearch(IDictionary<SeriesSearchField, string> searchParameters)
        {
            _seriessClient.WithSearch(searchParameters);
            return this;
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _seriessClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery IncludeEmbed(SeriesEmbed embed)
        {
            _seriessClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSort(SeriesSortField orderBy)
        {
            _seriessClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public ISeriesClientSearchQuery WithSortDescending(SeriesSortField orderBy)
        {
            _seriessClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Series>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _seriessClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Series> ExecuteSearch(bool ignoreCache = false)
        {
            return _seriessClient.ExecuteSearch(ignoreCache);
        }
    }
}