using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for submitting a Platform Id Query
    /// </summary>
    class PlatformsClientIdQuery : IPlatformsClientIdQuery
    {
        private readonly PlatformsClient _platformsClient;
        internal PlatformsClientIdQuery(PlatformsClient platformsClient)
        {
            _platformsClient = platformsClient;
        }

        /// <inheritdoc/>
        public async Task<Platform> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _platformsClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Platform Get(bool ignoreCache = false)
        {
            return _platformsClient.Get(ignoreCache);
        }
    }
}