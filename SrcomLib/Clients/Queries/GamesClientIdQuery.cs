using SrcomLib.Clients.Interfaces;
using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients.Queries
{
    /// <summary>
    /// Class for building and submitting a Game Id Query
    /// </summary>
    public class GamesClientIdQuery : IGamesClientIdQuery
    {
        private readonly GamesClient _gamesClient;
        internal GamesClientIdQuery(GamesClient gamesClient)
        {
            _gamesClient = gamesClient;
        }

        /// <inheritdoc/>
        public ICategoriesSubClientSearchQuery Categories()
        {
            return _gamesClient.Categories();
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery DerivedGames()
        {
            return _gamesClient.DerivedGames();
        }

        /// <inheritdoc/>
        public ILevelsSubClientSearchQuery Levels()
        {
            return _gamesClient.Levels();
        }

        /// <inheritdoc/>
        public IVariablesSubClientExecutor Variables()
        {
            return _gamesClient.Variables();
        }

        /// <inheritdoc/>
        public IRecordsClient Records()
        {
            return _gamesClient.Records();
        }

        /// <inheritdoc/>
        public IGamesClientIdQuery IncludeEmbed(GameEmbed embed)
        {
            _gamesClient.IncludeEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientIdQuery IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _gamesClient.IncludeCategoryEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientIdQuery IncludeLevelEmbed(LevelEmbed embed)
        {
            _gamesClient.IncludeLevelEmbed(embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientIdQuery IncludeEmbeds(List<GameEmbed> embeds)
        {
            _gamesClient.IncludeEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientIdQuery IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            _gamesClient.IncludeCategoryEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientIdQuery IncludeLevelEmbeds(List<LevelEmbed> embeds)
        {
            _gamesClient.IncludeLevelEmbeds(embeds);
            return this;
        }

        /// <inheritdoc/>
        public async Task<Game> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _gamesClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public Game Get(bool ignoreCache = false)
        {
            return _gamesClient.Get(ignoreCache);
        }
    }
}