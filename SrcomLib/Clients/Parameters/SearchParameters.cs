using System;
using System.Collections.Generic;
using System.Text;

namespace SrcomLib.Clients.Parameters
{
    internal class SearchParameters<TApiObject>
    {
        private readonly Dictionary<string, string> _searchParameters;
        private readonly Type _type;

        public string SearchUriPart
        {
            get
            {
                var sb = new StringBuilder();
                foreach(var kvp in _searchParameters)
                {
                    sb.Append(sb.Length > 0 ? "&" : string.Empty)
                        .Append($"{kvp.Key}={kvp.Value}");
                }
                return sb.ToString();
            }
        }

        public SearchParameters()
        {
            _searchParameters = new Dictionary<string, string>();
            _type = typeof(TApiObject);
        }

        public void Clear()
        {
            _searchParameters.Clear();
        }

        public void Add(string field, string searchValue)
        {
            if (!SearchFieldSupported(field)) return;
            _searchParameters.AddOrUpdate(field, searchValue);
        }

        public void AddVariable(string variableId, string searchValue)
        {
            _searchParameters.AddOrUpdate($"{Constants.SearchFieldNames.Variable}{variableId}", searchValue);
        }

        public void Add(IDictionary<string, string> searchParameters)
        {
            foreach (var kvp in searchParameters)
            {
                Add(kvp.Key, kvp.Value);
            }
        }

        public void AddVariables(IDictionary<string, string> variableSearchParameters)
        {
            foreach (var kvp in variableSearchParameters)
            {
                AddVariable(kvp.Key, kvp.Value);
            }
        }

        private bool SearchFieldSupported(string searchField)
        {
            return Constants.SupportedSearchFields.ContainsElement(_type, searchField, StringComparison.OrdinalIgnoreCase, true);
        }
    }
}