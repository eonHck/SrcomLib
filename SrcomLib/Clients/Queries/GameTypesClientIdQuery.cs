using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for submitting a Game Type Id Query
    /// </summary>
    class GameTypesClientIdQuery : IGameTypesClientIdQuery
    {
        private readonly GameTypesClient _gameTypesClient;
        internal GameTypesClientIdQuery(GameTypesClient gameTypesClient)
        {
            _gameTypesClient = gameTypesClient;
        }

        /// <inheritdoc/>
        public async Task<GameType> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _gameTypesClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public GameType Get(bool ignoreCache = false)
        {
            return _gameTypesClient.Get(ignoreCache);
        }
    }
}