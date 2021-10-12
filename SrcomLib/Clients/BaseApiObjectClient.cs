using SrcomLib.Clients.Parameters;
using SrcomLib.Mapping;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SrcomLib.Clients
{
    internal class BaseApiObjectClient<TApiObject, TResponseObject>
    {
        internal readonly SrcomClient client;
        internal readonly ClientParameters<TApiObject> clientParameters;

        internal BaseApiObjectClient(SrcomClient client, uint maxSearchRecords)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            clientParameters = new ClientParameters<TApiObject>(maxSearchRecords);
            Clear();
        }

        public void Clear()
        {
            clientParameters.Clear();
        }

        public void WithId(string id)
        {
            clientParameters.SetId(id);
        }

        public void WithSubObjectId(ApiObject apiObject, string objectId, string subEndpoint)
        {
            clientParameters.SetSubClient();
            clientParameters.SetId($"{Constants.Endpoints[Constants.ApiObjectTypeMap[apiObject]]}/{objectId}/{subEndpoint}");
        }

        public void WithSearch(SearchField field, string searchValue)
        {
            if (field == SearchField.Variable) return;

            clientParameters.AddSearchParameter(field.GetStringValue(), searchValue);
        }

        public void WithVariableSearch(string variableId, string searchValue)
        {
            clientParameters.AddVariableSearchParameter(variableId, searchValue);
        }

        public void WithSearch(IDictionary<SearchField, string> searchParameters)
        {
            if (searchParameters is null) return;

            if (searchParameters.ContainsKey(SearchField.Variable))
            {
                searchParameters.Remove(SearchField.Variable);
            }

            if (searchParameters.Count == 0) return;

            clientParameters.AddSearchParameters(ObjectMapping.Mapper.Map<IDictionary<string, string>>(searchParameters));
        }

        public void WithVariableSearch(IDictionary<string, string> variableSearchParameters)
        {
            if (variableSearchParameters is null || variableSearchParameters.Count == 0) return;

            clientParameters.AddVariableSearchParameters(variableSearchParameters);
        }

        public void IncludeEmbed(Embed embed)
        {
            clientParameters.AddEmbed(embed.GetStringValue());
        }

        public void IncludeNestedEmbed(ApiObject apiObject, Embed embed)
        {
            clientParameters.AddNestedEmbed(Constants.Endpoints[Constants.ApiObjectTypeMap[apiObject]], embed.GetStringValue());
        }

        public void IncludeEmbeds(List<Embed> embeds)
        {
            clientParameters.AddEmbeds(ObjectMapping.Mapper.Map<List<string>>(embeds));
        }

        public void IncludeNestedEmbeds(List<KeyValuePair<ApiObject, Embed>> nestedEmbeds)
        {
            clientParameters.AddNestedEmbeds(ObjectMapping.Mapper.Map<List<(string, string)>>(nestedEmbeds));
        }

        public void WithSort(SortField orderBy)
        {
            clientParameters.AddSort(orderBy.GetStringValue());
        }

        public void WithSortDescending(SortField orderBy)
        {
            clientParameters.AddSortDescending(orderBy.GetStringValue());
        }

        public void WithMaxRecordsReturned(uint maxRecords)
        {
            clientParameters.MaxRecords = maxRecords;
        }

        public async Task<TResponseObject> GetAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            var apiObject = await client.GetAsync<TApiObject>(clientParameters.UriPart, cancellationToken, ignoreCache).ConfigureAwait(false);
            return ObjectMapping.Mapper.Map<TResponseObject>(apiObject);
        }

        public async Task<IReadOnlyList<TResponseObject>> GetListAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            var apiObject = await client.GetAsync<List<TApiObject>>(clientParameters.UriPart, cancellationToken, ignoreCache).ConfigureAwait(false);
            return ObjectMapping.Mapper.Map<IReadOnlyList<TResponseObject>>(apiObject);
        }

        public async Task<List<TResponseObject>> ExecuteSearchAsync(bool ignoreCache = false, CancellationToken cancellationToken = default)
        {
            var apiList = await client.GetPagedAsync<TApiObject>(clientParameters.UriPart, cancellationToken, clientParameters.MaxRecords, ignoreCache).ConfigureAwait(false);
            return ObjectMapping.Mapper.Map<List<TResponseObject>>(apiList);
        }

        public TResponseObject Get(bool ignoreCache = false)
        {
            var apiObject = client.Get<TApiObject>(clientParameters.UriPart, ignoreCache);
            return ObjectMapping.Mapper.Map<TResponseObject>(apiObject);
        }

        public IReadOnlyList<TResponseObject> GetList(bool ignoreCache = false)
        {
            var apiObject = client.Get<List<TApiObject>>(clientParameters.UriPart, ignoreCache);
            return ObjectMapping.Mapper.Map<IReadOnlyList<TResponseObject>>(apiObject);
        }

        public IReadOnlyList<TResponseObject> ExecuteSearch(bool ignoreCache = false)
        {
            var apiList = client.GetPaged<TApiObject>(clientParameters.UriPart, clientParameters.MaxRecords, ignoreCache);
            return ObjectMapping.Mapper.Map<IReadOnlyList<TResponseObject>>(apiList);
        }
    }
}