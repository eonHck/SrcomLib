using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Interface for Building a Game Sub-Query
    /// </summary>
    public class GamesSubClientSearchQuery : IGamesSubClientSearchQuery
    {
        private readonly GamesClient _gamesClient;
        internal GamesSubClientSearchQuery(GamesClient gamesClient)
        {
            _gamesClient = gamesClient;
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery WithSearch(GameSearchField field, string searchValue)
        {
            _gamesClient.WithSearch(field, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery WithSearch(IDictionary<GameSearchField, string> searchParameters)
        {
            _gamesClient.WithSearch(searchParameters);
            return this;
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery WithSort(GameSortField orderBy)
        {
            _gamesClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery WithSortDescending(GameSortField orderBy)
        {
            _gamesClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _gamesClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Game>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _gamesClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Game> ExecuteSearch(bool ignoreCache = false)
        {
            return _gamesClient.ExecuteSearch(ignoreCache);
        }
    }
}