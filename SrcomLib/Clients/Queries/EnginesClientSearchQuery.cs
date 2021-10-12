using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting an Engine search Query
    /// </summary>
    public class EnginesClientSearchQuery : IEnginesClientSearchQuery
    {
        private readonly EnginesClient _enginesClient;
        internal EnginesClientSearchQuery(EnginesClient enginesClient)
        {
            _enginesClient = enginesClient;
        }

        /// <inheritdoc/>
        public IEnginesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _enginesClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IEnginesClientSearchQuery WithSort(EngineSortField orderBy)
        {
            _enginesClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IEnginesClientSearchQuery WithSortDescending(EngineSortField orderBy)
        {
            _enginesClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Engine>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _enginesClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Engine> ExecuteSearch(bool ignoreCache = false)
        {
            return _enginesClient.ExecuteSearch(ignoreCache);
        }
    }
}