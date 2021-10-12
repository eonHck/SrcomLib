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
    /// Class for Building a Personal Bests Sub-Query
    /// </summary>
    public class PersonalBestsClient : IPersonalBestsClient
    {
        private readonly BaseApiObjectClient<api.PersonalBests, PersonalBests> _baseClient;
        private const string subEndpoint = "personal-bests";
        internal PersonalBestsClient(SrcomClient client, uint maxSearchRecords, ApiObject apiObject, string objectId)
        {
            _baseClient = new BaseApiObjectClient<api.PersonalBests, PersonalBests>(client, maxSearchRecords);
            _baseClient.Clear();
            _baseClient.WithSubObjectId(apiObject, objectId, subEndpoint);
        }
        internal IPersonalBestsClient Clear()
        {
            _baseClient.Clear();
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient WithSearch(PersonalBestsSearchField field, string searchValue)
        {
            _baseClient.WithSearch((SearchField)field, searchValue);
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient WithSearch(IDictionary<PersonalBestsSearchField, string> searchParameters)
        {
            _baseClient.WithSearch(searchParameters.ToBaseSearchDictionary());
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeEmbed(PersonalBestsEmbed embed)
        {
            _baseClient.IncludeEmbed((Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeCategoryEmbed(CategoryEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Category, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeGameEmbed(GameEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Game, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeLevelEmbed(LevelEmbed embed)
        {
            _baseClient.IncludeNestedEmbed(ApiObject.Level, (Embed)embed);
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeEmbeds(List<PersonalBestsEmbed> embeds)
        {
            _baseClient.IncludeEmbeds(embeds.ToBaseEmbedList());
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeCategoryEmbeds(List<CategoryEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Category, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeGameEmbeds(List<GameEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Game, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public IPersonalBestsClient IncludeLevelEmbeds(List<LevelEmbed> embeds)
        {
            var nestedEmbeds = embeds.Select(e => new KeyValuePair<ApiObject, Embed>(ApiObject.Level, (Embed)e)).ToList();
            _baseClient.IncludeNestedEmbeds(nestedEmbeds);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyList<PersonalBests>> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            return await _baseClient.GetListAsync(ignoreCache, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public IReadOnlyList<PersonalBests> Get(bool ignoreCache = false)
        {
            return _baseClient.GetList(ignoreCache);
        }
    }
}
