using api = SrcomLib.ApiObjects;
using SrcomLib.Clients.Interfaces;
using System.Collections.Generic;
using SrcomLib.ResponseObjects;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace SrcomLib.Clients
{
    /// <summary>
    /// Class for Building a Records Sub-Query
    /// </summary>
    public class RecordsClient : IRecordsClient
    {
        private readonly BaseApiObjectClient<api.Leaderboard, Leaderboard> _baseClient;
        private const string subEndpoint = "records";
        internal RecordsClient(SrcomClient client, uint maxSearchRecords, ApiObject apiObject, string objectId)
        {
            _baseClient = new BaseApiObjectClient<api.Leaderboard, Leaderboard>(client, maxSearchRecords);
            _baseClient.Clear();
            _baseClient.WithSubObjectId(apiObject, objectId, subEndpoint);
        }
        internal IRecordsClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeEmbed(LeaderboardEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Category, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeGameEmbed(GameEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Game, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeLevelEmbed(LevelEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Level, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeEmbeds(List<LeaderboardEmbed> embeds)
        {
            _baseClient.IncludeEmbeds(embeds.ToBaseEmbedList());
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Category, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeGameEmbeds(List<GameEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Game, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IRecordsClient IncludeLevelEmbeds(List<LevelEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Level, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Leaderboard>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Leaderboard> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}
