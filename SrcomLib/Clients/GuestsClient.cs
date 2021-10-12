using api = SrcomLib.ApiObjects;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;
using SrcomLib.Clients.Interfaces;

namespace SrcomLib.Clients
{
    /// <summary>
    /// Class for building and submitting a Guest request
    /// </summary>
    public class GuestsClient : IGuestsClient, IGuestsClientExecutor
    {
        private readonly BaseApiObjectClient<api.Guest, Guest> _baseClient;
        internal GuestsClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Guest, Guest>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IGuestsClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IGuestsClientExecutor WithName(string name)
        {
            _baseClient.WithId(name);
            return this;
        }

        /// <inheritdoc/>
        public async Task<Guest> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Guest Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }
    }
}