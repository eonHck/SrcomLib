using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for submitting a Publisher Id Query
    /// </summary>
    class PublishersClientIdQuery : IPublishersClientIdQuery
    {
        private readonly PublishersClient _publishersClient;
        internal PublishersClientIdQuery(PublishersClient publishersClient)
        {
            _publishersClient = publishersClient;
        }

        /// <inheritdoc/>
        public async Task<Publisher> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _publishersClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public Publisher Get(bool ignoreCache = false)
        {
            return _publishersClient.Get(ignoreCache);
        }
    }
}