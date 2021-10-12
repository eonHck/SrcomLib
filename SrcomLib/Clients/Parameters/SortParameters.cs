using System;

namespace SrcomLib.Clients.Parameters
{
    internal class SortParameters<TApiObject>
    {
        private string _sort;
        private string _sortDir;
        private readonly Type _type;

        public string SortUriPart => (!string.IsNullOrEmpty(_sort)) ? $"orderby={_sort}&direction={_sortDir}" : string.Empty;

        public SortParameters()
        {
            _sort = string.Empty;
            _sortDir = "asc";
            _type = typeof(TApiObject);
        }

        public void Clear()
        {
            _sort = string.Empty;
            _sortDir = "asc";
        }

        public void Add(string orderBy)
        {
            if (!AddSortField(orderBy)) return;
            _sortDir = "asc";
        }

        public void AddDescending(string orderBy)
        {
            if (!AddSortField(orderBy)) return;
            _sortDir = "desc";
        }

        private bool AddSortField(string orderBy)
        {
            if (!SortFieldSupported(orderBy)) return false;
            _sort = orderBy;
            return true;
        }

        private bool SortFieldSupported(string orderBy)
        {
            return Constants.SupportedSortFields.ContainsElement(_type, orderBy, StringComparison.OrdinalIgnoreCase);
        }
    }
}