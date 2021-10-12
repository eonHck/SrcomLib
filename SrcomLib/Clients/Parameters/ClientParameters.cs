using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrcomLib.Clients.Parameters
{
    internal class ClientParameters<TApiObject>
    {
        private string _id;
        private bool _isSubClient;
        private readonly uint _defaultMaxSearchRecords;
        private readonly Embeds<TApiObject> _embeds;
        private readonly SearchParameters<TApiObject> _searchParameters;
        private readonly SortParameters<TApiObject> _sortParameters;

        public uint MaxRecords { get; set; }

        public uint RecordsPerPage => MaxRecords >= 200 ? 200 : MaxRecords;

        public string UriPart
        {
            get
            {
                var queryParts = new List<string>
                {
                    _embeds.EmbedUriPart,
                    _searchParameters.SearchUriPart,
                    _sortParameters.SortUriPart
                };

                var sb = new StringBuilder();
                sb.Append(GetUriPartPrefix());

                var joinCharacter = "?";

                foreach (var part in queryParts.Where(i => !string.IsNullOrEmpty(i)))
                {
                    sb.Append($"{joinCharacter}{part}");
                    joinCharacter = "&";
                }

                sb.Append(string.IsNullOrEmpty(_id) ? $"{joinCharacter}max={RecordsPerPage}" : string.Empty);

                return sb.ToString();
            }
        }


        public ClientParameters(uint maxSearchRecords)
        {
            _defaultMaxSearchRecords = maxSearchRecords;
            _embeds = new Embeds<TApiObject>();
            _searchParameters = new SearchParameters<TApiObject>();
            _sortParameters = new SortParameters<TApiObject>();
            Clear();
        }

        public void Clear()
        {
            MaxRecords = _defaultMaxSearchRecords;
            _id = string.Empty;
            _isSubClient = false;
            _embeds.Clear();
            _searchParameters.Clear();
            _sortParameters.Clear();
        }

        public void SetId(string id) => _id = id;
        public void AddEmbed(string embed) => _embeds.Add(embed);
        public void AddNestedEmbed(string apiObject, string embed) => _embeds.AddNestedEmbed(apiObject, embed);
        public void AddEmbeds(IEnumerable<string> embeds) => _embeds.AddRange(embeds);
        public void AddNestedEmbeds(IEnumerable<(string, string)> nestedEmbeds) => _embeds.AddNestedRange(nestedEmbeds);
        public void AddSearchParameter(string field, string searchValue) => _searchParameters.Add(field, searchValue);
        public void AddVariableSearchParameter(string variableId, string searchValue) => _searchParameters.AddVariable(variableId, searchValue);
        public void AddSearchParameters(IDictionary<string, string> searchParameters) => _searchParameters.Add(searchParameters);
        public void AddVariableSearchParameters(IDictionary<string, string> variableSearchParameters) => _searchParameters.AddVariables(variableSearchParameters);
        public void AddSort(string orderBy) => _sortParameters.Add(orderBy);
        public void AddSortDescending(string orderBy) => _sortParameters.AddDescending(orderBy);
        public void SetSubClient() => _isSubClient = true;

        private string GetUriPartPrefix()
        {
            if (_isSubClient)
            {
                return _id;
            }

            return !string.IsNullOrEmpty(_id) 
                ? $"{Constants.Endpoints[typeof(TApiObject)]}/{_id}" 
                : Constants.Endpoints[typeof(TApiObject)];
        }
    }
}