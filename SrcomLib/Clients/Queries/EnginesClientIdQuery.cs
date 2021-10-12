using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for submitting an Engine Id Query
    /// </summary>
    class EnginesClientIdQuery : IEnginesClientIdQuery
    {
        private readonly EnginesClient _enginesClient;
        internal EnginesClientIdQuery(EnginesClient enginesClient)
        {
            _enginesClient = enginesClient;
        }

        /// <inheritdoc/>
        public async Task<Engine> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _enginesClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public Engine Get(bool ignoreCache = false)
        {
            return _enginesClient.Get(ignoreCache);
        }
    }
}