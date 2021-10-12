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
    /// Class for starting building a Run request
    /// </summary>
    public class RunsClient : IRunsClient
    {
        private readonly BaseApiObjectClient<api.Run, Run> _baseClient;
        internal RunsClient(SrcomClient client, uint maxSearchRecords)
        {
            _baseClient = new BaseApiObjectClient<api.Run, Run>(client, maxSearchRecords);
            _baseClient.Clear();
        }
        internal IRunsClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientIdQuery WithId(string id)
        {
            _baseClient.WithId(id);
            return new RunsClientIdQuery(this);
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSearch(RunSearchField field, string searchValue)
        {
            _baseClient.WithSearch((SearchField)field, searchValue);
            return new RunsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSearch(IDictionary<RunSearchField, string> searchParameters)
        {
            _baseClient.WithSearch(searchParameters.ToBaseSearchDictionary());
            return new RunsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithMaxRecordsReturned(uint maxRecords)
        {
            _baseClient.WithMaxRecordsReturned(maxRecords);
            return new RunsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IRunsClient IncludeEmbed(RunEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClient IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Category, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClient IncludeGameEmbed(GameEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Game, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClient IncludeLevelEmbed(LevelEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Level, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClient IncludeEmbeds(List<RunEmbed> embeds)
        {
            _baseClient.IncludeEmbeds(embeds.ToBaseEmbedList());
            return this;
        }

        /// <inheritdoc/>
        public IRunsClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Category, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClient IncludeGameEmbeds(List<GameEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Game, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClient IncludeLevelEmbeds(List<LevelEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Level, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSort(RunSortField orderBy)
        {
            _baseClient.WithSort((SortField)orderBy);
            return new RunsClientSearchQuery(this);
        }

        /// <inheritdoc/>
        public IRunsClientSearchQuery WithSortDescending(RunSortField orderBy)
        {
            _baseClient.WithSortDescending((SortField)orderBy);
            return new RunsClientSearchQuery(this);
        }

        internal async Task<Run> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<Run>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.ExecuteSearchAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        internal Run Get(bool ignoreCache = false)
        {
            return _baseClient.Get(ignoreCache);
        }

        /// <inheritdoc/>
        public IReadOnlyList<Run> ExecuteSearch(bool ignoreCache = false)
        {
            return _baseClient.ExecuteSearch(ignoreCache);
        }
    }
}