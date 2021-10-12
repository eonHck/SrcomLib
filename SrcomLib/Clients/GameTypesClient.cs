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
    /// Class for starting building a Game Type request
    /// </summary>
    public class GameTypesClient : IGameTypesClient
    {
        private readonly BaseApiObjectClient<api.GameType, GameType> _baseClient;
        internal GameTypesClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.GameType, GameType>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IGameTypesClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IGameTypesClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new GameTypesClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IGameTypesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new GameTypesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGameTypesClientSearchQuery WithSort(GameTypeSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new GameTypesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGameTypesClientSearchQuery WithSortDescending(GameTypeSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new GameTypesClientSearchQuery(this);
        }

        internal async Task<GameType> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<GameType>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        internal GameType Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<GameType> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}