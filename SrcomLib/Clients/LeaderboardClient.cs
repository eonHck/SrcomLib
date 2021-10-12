using api = SrcomLib.ApiObjects;
using res = SrcomLib.ResponseObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SrcomLib.Clients.Interfaces;
using System.Linq;

namespace SrcomLib.Clients
{
    /// <summary>
    /// Class for handling the Leaderboard requests
    /// </summary>
    public class LeaderboardClient : ILeaderboardClient, ILeaderboardClientCategorySelection, ILeaderboardClientExecutor
    {
        private readonly BaseApiObjectClient<api.Leaderboard, res.Leaderboard> _baseClient;
        private string _gameId;
        private string _levelId;

        internal LeaderboardClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Leaderboard, res.Leaderboard>(client, maxSearchRecords);
            Clear();
        }

        internal ILeaderboardClient Clear()
        {
            _gameId = string.Empty;
            _levelId = string.Empty;
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientCategorySelection WithGameId(string gameId)
        {
            if (string.IsNullOrEmpty(gameId)) throw new ArgumentNullException(nameof(gameId));
            _gameId = gameId;
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientCategorySelection WithLevelId(string levelId)
        {
            if (string.IsNullOrEmpty(levelId)) throw new ArgumentNullException(nameof(levelId));
            _levelId = levelId;
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor WithCategoryId(string categoryId)
        {
            if (string.IsNullOrEmpty(categoryId)) throw new ArgumentNullException(nameof(categoryId));

            if (string.IsNullOrEmpty(_levelId))
            {
                _baseClient.WithId($"{_gameId}/category/{categoryId}");
                return this;
            }

            _baseClient.WithId($"{_gameId}/level/{_levelId}/{categoryId}");
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor WithSearch(LeaderboardSearchField field, string searchValue)
        {
            _baseClient.WithSearch((SearchField)field, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor WithVariableSearch(string variableId, string searchValue)
        {
            _baseClient.WithVariableSearch(variableId, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor WithSearch(IDictionary<LeaderboardSearchField, string> searchParameters)
        {
            _baseClient.WithSearch(searchParameters.ToBaseSearchDictionary());
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor WithVariableSearch(IDictionary<string, string> variableSearchParameters)
        {
            _baseClient.WithVariableSearch(variableSearchParameters);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeEmbed(LeaderboardEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Category, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeGameEmbed(GameEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Game, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeLevelEmbed(LevelEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Level, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeEmbeds(List<LeaderboardEmbed> embeds)
        {
            _baseClient.IncludeEmbeds(embeds.ToBaseEmbedList());
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Category, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeGameEmbeds(List<GameEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Game, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public ILeaderboardClientExecutor IncludeLevelEmbeds(List<LevelEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Level, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public async Task<res.Leaderboard> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public res.Leaderboard Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }
    }
}
