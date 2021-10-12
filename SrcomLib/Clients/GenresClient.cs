using api = SrcomLib.ApiObjects;
using SrcomLib.ResponseObjects;
using SrcomLib.Clients.Interfaces;
using SrcomLib.Clients.Queries.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using SrcomLib.Clients.Queries;

namespace SrcomLib.Clients
{
    /// <summary>
    /// Interface for starting building a Genre request
    /// </summary>
    public class GenresClient : IGenresClient
    {
        private readonly BaseApiObjectClient<api.Genre, Genre> _baseClient;
        internal GenresClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Genre, Genre>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IGenresClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IGenresClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new GenresClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IGenresClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new GenresClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGenresClientSearchQuery WithSort(GenreSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new GenresClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGenresClientSearchQuery WithSortDescending(GenreSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new GenresClientSearchQuery(this);
        }

        internal async Task<Genre> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Genre>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        internal Genre Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Genre> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}