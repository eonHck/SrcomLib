using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Game Type search Query
    /// </summary>
    public class GameTypesClientSearchQuery : IGameTypesClientSearchQuery
    {
        private readonly GameTypesClient _gameTypesClient;
        internal GameTypesClientSearchQuery(GameTypesClient gameTypesClient)
        {
            _gameTypesClient = gameTypesClient;
        }

        /// <inheritdoc/>
        public IGameTypesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _gameTypesClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IGameTypesClientSearchQuery WithSort(GameTypeSortField orderBy)
        {
            _gameTypesClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IGameTypesClientSearchQuery WithSortDescending(GameTypeSortField orderBy)
        {
            _gameTypesClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<GameType>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _gameTypesClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<GameType> ExecuteSearch(bool ignoreCache = false)
        {
            return _gameTypesClient.ExecuteSearch(ignoreCache);
        }
    }
}