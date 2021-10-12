using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Game search Query
    /// </summary>
    public class GamesClientSearchQuery : IGamesClientSearchQuery
    {
        private readonly GamesClient _gamesClient;
        internal GamesClientSearchQuery(GamesClient gamesClient)
        {
            _gamesClient = gamesClient;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSearch(GameSearchField field, string searchValue)
        {
            _gamesClient.WithSearch(field, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSearch(IDictionary<GameSearchField, string> searchParameters)
        {
            _gamesClient.WithSearch(searchParameters);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _gamesClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery IncludeEmbed(GameEmbed embed)
        {
            _gamesClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _gamesClient.IncludeCategoryEmbed(embed);
            return this;
        }

        public IGamesClientSearchQuery IncludeLevelEmbed(LevelEmbed embed)
        {
            _gamesClient.IncludeLevelEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery IncludeEmbeds(List<GameEmbed> embeds)
        {
            _gamesClient.IncludeEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            _gamesClient.IncludeCategoryEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery IncludeLevelEmbeds(List<LevelEmbed> embeds)
        {
            _gamesClient.IncludeLevelEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSort(GameSortField orderBy)
        {
            _gamesClient.WithSort(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSortDescending(GameSortField orderBy)
        {
            _gamesClient.WithSortDescending(orderBy);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Game>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _gamesClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Game> ExecuteSearch(bool ignoreCache = false)
        {
            return _gamesClient.ExecuteSearch(ignoreCache);
        }
    }
}