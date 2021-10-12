using api = SrcomLib.ApiObjects;
using SrcomLib.ResponseObjects;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using SrcomLib.Clients.Queries.Interfaces;
using SrcomLib.Clients.Queries;
using SrcomLib.Clients.Interfaces;
using System.Linq;

namespace SrcomLib.Clients
{
    /// <summary>
    /// Class for starting building a Game request
    /// </summary>
    public class GamesClient : IGamesClient
    {
        private readonly BaseApiObjectClient<api.Game, Game> _baseClient;
        private readonly SrcomClient _client;
        private readonly uint _maxSearchRecords;
        private string _id;
        private const string DerivedGamesSubEndpoint = "derived-games";

        internal GamesClient(SrcomClient client, uint maxSearchRecords) 
        {
            _client = client;
            _maxSearchRecords = maxSearchRecords;
            _baseClient = new BaseApiObjectClient<api.Game, Game>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IGamesClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        internal ICategoriesSubClientSearchQuery Categories()
        {
            return new CategoriesClient(_client, _maxSearchRecords)
                .GetSubClientSearchQuery(ApiObject.Game, _id);
        }

        /// <inheritdoc/>
        public IGamesSubClientSearchQuery DerivedGames()
        {
            _baseClient.WithSubObjectId(ApiObject.Game, _id, DerivedGamesSubEndpoint);
            return new GamesSubClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public ILevelsSubClientSearchQuery Levels()
        {
            return new LevelsClient(_client, _maxSearchRecords)
                .GetSubClientSearchQuery(ApiObject.Game, _id);
        }

        internal IVariablesSubClientExecutor Variables()
        {
            return new VariablesClient(_client, _maxSearchRecords)
                .GetSubClientSearchQuery(ApiObject.Game, _id);
        }

        internal IRecordsClient Records()
        {
            return new RecordsClient(_client, _maxSearchRecords, ApiObject.Game, _id).Clear();
        }

        internal IGamesSubClientSearchQuery GetSubClientSearchQuery(ApiObject apiObject, string objectId)
        {
            _baseClient.WithSubObjectId(apiObject, objectId, Constants.Endpoints[typeof(api.Game)]);
            return new GamesSubClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGamesClientIdQuery WithId(string id)
        {
            _id = id;
            _baseClient.WithId(id);
            return new GamesClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSearch(GameSearchField field, string searchValue)
        {
            _baseClient.WithSearch((SearchField)field, searchValue);
            return new GamesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSearch(IDictionary<GameSearchField, string> searchParameters)
        {
            _baseClient.WithSearch(searchParameters.ToBaseSearchDictionary());
            return new GamesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new GamesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGamesClient IncludeEmbed(GameEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClient IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Category, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClient IncludeLevelEmbed(LevelEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Level, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClient IncludeEmbeds(List<GameEmbed> embeds)
        {
            _baseClient.IncludeEmbeds(embeds.ToBaseEmbedList());
            return this;
        }

        /// <inheritdoc/>
        public IGamesClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Category, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClient IncludeLevelEmbeds(List<LevelEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Level, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSort(GameSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new GamesClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IGamesClientSearchQuery WithSortDescending(GameSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new GamesClientSearchQuery(this);
        }

        internal async Task<Game> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Game>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken);
        }

        internal Game Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Game> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}