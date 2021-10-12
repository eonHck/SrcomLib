using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class SearchDictionaryConverter : ITypeConverter<IDictionary<SearchField, string>, IDictionary<string, string>>
    {
        public IDictionary<string, string> Convert(IDictionary<SearchField, string> source, IDictionary<string, string> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }
            return source.ToDictionary(t => t.Key.GetStringValue(), t => t.Value);
        }
    }
}