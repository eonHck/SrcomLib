using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace SrcomLib.Mapping.Converters
{
    internal class NestedEmbedListConverter : ITypeConverter<List<KeyValuePair<ApiObject, Embed>>, List<(string, string)>>
    {
        public List<(string, string)> Convert(List<KeyValuePair<ApiObject, Embed>> source, List<(string, string)> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            return source.Select(kvp => (Constants.Endpoints[Constants.ApiObjectTypeMap[kvp.Key]], kvp.Value.GetStringValue()))
                .ToList();
        }
    }
}