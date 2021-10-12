using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class RunVariableValuesConverter : ITypeConverter<Dictionary<string, string>, IReadOnlyList<RunVariableValue>>
    {
        public IReadOnlyList<RunVariableValue> Convert(Dictionary<string, string> source, IReadOnlyList<RunVariableValue> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            return source.Select(kvp => new RunVariableValue
                    {
                        VariableId = kvp.Key,
                        VariableValueId = kvp.Value
                    }).ToList()
                    .AsReadOnly();
        }
    }
}