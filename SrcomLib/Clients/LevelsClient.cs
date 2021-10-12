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
    /// Class for starting building a Level request
    /// </summary>
    public class LevelsClient : ILevelsClient
    {
        private readonly BaseApiObjectClient<api.Level, Level> _baseClient;
        private readonly SrcomClient _client;
        private readonly uint _maxSearchRecords;
        private string _id;
        internal LevelsClient(SrcomClient client, uint maxSearchRecords)
        {
            _client = client;
            _maxSearchRecords = maxSearchRecords;
            _baseClient = new BaseApiObjectClient<api.Level, Level>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal ILevelsClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public ILevelsClientIdQuery WithId(string id)
        {
            _id = id;
            _baseClient.WithId(id);
            return new LevelsClientIdQuery(this);
        }
        
        internal ICategoriesSubClientSearchQuery Categories()
        {
            return new CategoriesClient(_client, _maxSearchRecords)
                .GetSubClientSearchQuery(ApiObject.Level, _id);
        }

        internal IVariablesSubClientExecutor Variables()
        {
            return new VariablesClient(_client, _maxSearchRecords)
                .GetSubClientSearchQuery(ApiObject.Level, _id);
        }

        internal IRecordsClient Records()
        {
            return new RecordsClient(_client, _maxSearchRecords, ApiObject.Level, _id).Clear();
        }

        internal ILevelsSubClientSearchQuery GetSubClientSearchQuery(ApiObject apiObject, string objectId)
        {
            _baseClient.WithSubObjectId(apiObject, objectId, Constants.Endpoints[typeof(api.Level)]);
            return new LevelsSubClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public ILevelsClient IncludeEmbed(LevelEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ILevelsClient IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Category, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public ILevelsClient IncludeEmbeds(List<LevelEmbed> embeds)
        {
            _baseClient.IncludeEmbeds(embeds.ToBaseEmbedList());
            return this;
        }

        /// <inheritdoc/>
        public ILevelsClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Category, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        internal void WithSort(LevelSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
        }

        internal void WithSortDescending(LevelSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
        }

        internal async Task<Level> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        internal Level Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        internal async Task<IReadOnlyList<Level>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetListAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        internal IReadOnlyList<Level> GetList(bool ignoreCache = false)
        {
            return _baseClient.GetList(ignoreCache);
        }
    }
}