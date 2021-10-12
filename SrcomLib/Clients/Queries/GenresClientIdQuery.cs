using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for submitting a Genre Id Query
    /// </summary>
    class GenresClientIdQuery : IGenresClientIdQuery
    {
        private readonly GenresClient _genresClient;
        internal GenresClientIdQuery(GenresClient genresClient)
        {
            _genresClient = genresClient;
        }

        /// <inheritdoc/>
        public async Task<Genre> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _genresClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public Genre Get(bool ignoreCache = false)
        {
            return _genresClient.Get(ignoreCache);
        }
    }
}