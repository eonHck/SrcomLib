using api = SrcomLib.ApiObjects;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;
using SrcomLib.Clients.Interfaces;
using System.Collections.Generic;

namespace SrcomLib.Clients
{
    /// <summary>
    /// Interface for building and submitting a Variable request
    /// </summary>
    public class VariablesClient : IVariablesClient, IVariablesClientExecutor, IVariablesSubClientExecutor
    {
        private readonly BaseApiObjectClient<api.Variable, Variable> _baseClient;
        internal VariablesClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Variable, Variable>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IVariablesClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        internal IVariablesSubClientExecutor GetSubClientSearchQuery(ApiObject apiObject, string objectId)
        {
            _baseClient.WithSubObjectId(apiObject, objectId, Constants.Endpoints[typeof(api.Variable)]);
            return this;
        }

        /// <inheritdoc/>
        public IVariablesClientExecutor WithId(string id)
        {
            _baseClient.WithId(id);
            return this;
        }

        /// <inheritdoc/>
        public async Task<Variable> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Variable Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Variable>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetListAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Variable> GetList(bool ignoreCache = false)
        {
            return _baseClient.GetList(ignoreCache);
        }
    }
}