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
    /// Class for handling the Leaderboard requests
    /// </summary>
    public class CategoriesClient : ICategoriesClient
    {
        private readonly BaseApiObjectClient<api.Category, Category> _baseClient;
        private readonly SrcomClient _client;
        private readonly uint _maxSearchRecords;
        private string _id;

        internal CategoriesClient(SrcomClient client, uint maxSearchRecords)
        {
            _client = client;
            _maxSearchRecords = maxSearchRecords;
            _baseClient = new BaseApiObjectClient<api.Category, Category>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal ICategoriesClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        internal ICategoriesSubClientSearchQuery GetSubClientSearchQuery(ApiObject apiObject, string objectId)
        {
            _baseClient.WithSubObjectId(apiObject, objectId, Constants.Endpoints[typeof(api.Category)]);
            return new CategoriesSubClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public ICategoriesClientIdQuery WithId(string id)
        {
            _id = id;
            _baseClient.WithId(id);
            return new CategoriesClientIdQuery(this);
        }

        internal IVariablesSubClientExecutor Variables()
        {
            return new VariablesClient(_client, _maxSearchRecords)
                .GetSubClientSearchQuery(ApiObject.Category, _id);
        }

        internal IRecordsClient Records()
        {
            return new RecordsClient(_client, _maxSearchRecords, ApiObject.Category, _id).Clear();
        }

        /// <inheritdoc/>
        public ICategoriesClient IncludeEmbed(CategoryEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesClient IncludeGameEmbed(GameEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Game, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesClient IncludeEmbeds(List<CategoryEmbed> embeds)
        {
            _baseClient.IncludeEmbeds(embeds.ToBaseEmbedList());
            return this;
        }

        /// <inheritdoc/>
        public ICategoriesClient IncludeGameEmbeds(List<GameEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Game, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        internal void ExcludeMiscellanousCategories()
        {
            _baseClient.WithSearch(SearchField.Miscellaneous, false.ToString());
        }

        internal void WithSort(CategorySortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
        }

        internal void WithSortDescending(CategorySortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
        }

        internal async Task<Category> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken);
        }

        internal Category Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        internal async Task<IReadOnlyList<Category>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetListAsync(ignoreCache, cancellationToken);
        }

        internal IReadOnlyList<Category> GetList(bool ignoreCache = false)
        {
            return _baseClient.GetList(ignoreCache);
        }
    }
}