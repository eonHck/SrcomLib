using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class EmbedListStringConverter : ITypeConverter<List<Embed>, List<string>>
    {
        public List<string> Convert(List<Embed> source, List<string> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }
            return source.Select(e => e.GetStringValue()).ToList();
        }
    }
}