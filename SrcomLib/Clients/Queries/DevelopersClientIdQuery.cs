using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for submitting a Developer Id Query
    /// </summary>
    class DevelopersClientIdQuery : IDevelopersClientIdQuery
    {
        private readonly DevelopersClient _developersClient;
        internal DevelopersClientIdQuery(DevelopersClient developersClient)
        {
            _developersClient = developersClient;
        }

        /// <inheritdoc/>
        public async Task<Developer> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _developersClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Developer Get(bool ignoreCache = false)
        {
            return _developersClient.Get(ignoreCache);
        }
    }
}