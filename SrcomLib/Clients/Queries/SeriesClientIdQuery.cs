using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Series Id Query
    /// </summary>
    public class SeriesClientIdQuery : ISeriesClientIdQuery
    {
        private readonly SeriesClient _seriesClient;

        internal SeriesClientIdQuery(SeriesClient seriesClient)
        {
            _seriesClient = seriesClient;
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery Games()
        {
            return _seriesClient.Games();
        }

        /// <inheritdoc/>
        public ISeriesClientIdQuery IncludeEmbed(SeriesEmbed embed)
        {
            _seriesClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public async Task<Series> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _seriesClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public Series Get(bool ignoreCache = false)
        {
            return _seriesClient.Get(ignoreCache);
        }
    }
}