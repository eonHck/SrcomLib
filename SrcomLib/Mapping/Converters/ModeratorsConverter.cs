using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class ModeratorsConverter : ITypeConverter<Dictionary<string, string>, IReadOnlyList<Moderator>>
    {
        public IReadOnlyList<Moderator> Convert(Dictionary<string, string> source, IReadOnlyList<Moderator> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            var moderatorTypeConverter = new ModeratorTypeConverter();

            return source.Select(i =>
                    new Moderator
                    {
                        UserId = i.Key,
                        ModeratorType = moderatorTypeConverter.Convert(i.Value, context)
                    })
                .ToList()
                .AsReadOnly();
        }
    }
}