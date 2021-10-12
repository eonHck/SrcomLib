using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Genre search Query
    /// </summary>
    public class GenresClientSearchQuery : IGenresClientSearchQuery
    {
        private readonly GenresClient _genresClient;
        internal GenresClientSearchQuery(GenresClient genresClient)
        {
            _genresClient = genresClient;
        }

        /// <inheritdoc/>
        public IGenresClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _genresClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IGenresClientSearchQuery WithSort(GenreSortField orderBy)
        {
            _genresClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IGenresClientSearchQuery WithSortDescending(GenreSortField orderBy)
        {
            _genresClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Genre>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _genresClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Genre> ExecuteSearch(bool ignoreCache = false)
        {
            return _genresClient.ExecuteSearch(ignoreCache);
        }
    }
}