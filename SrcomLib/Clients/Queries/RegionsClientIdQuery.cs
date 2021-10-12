using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for submitting a Region Id Query
    /// </summary>
    class RegionsClientIdQuery : IRegionsClientIdQuery
    {
        private readonly RegionsClient _regionsClient;
        internal RegionsClientIdQuery(RegionsClient regionsClient)
        {
            _regionsClient = regionsClient;
        }

        /// <inheritdoc/>
        public async Task<Region> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _regionsClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public Region Get(bool ignoreCache = false)
        {
            return _regionsClient.Get(ignoreCache);
        }
    }
}