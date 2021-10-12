using AutoMapper;
using System.Collections.Generic;
using resSub = SrcomLib.ResponseObjects.SubObjects;
using apiSub = SrcomLib.ApiObjects.SubObjects;

namespace SrcomLib.Mapping.Converters
{
    internal class VariableValueConverter : ITypeConverter<(KeyValuePair<string, apiSub.VariableValue>, string), resSub.VariableValue>
    {
        public resSub.VariableValue Convert((KeyValuePair<string, apiSub.VariableValue>, string) source, resSub.VariableValue destination, ResolutionContext context)
        {
            var key = source.Item1.Key;
            var value = source.Item1.Value;
            var variableId = source.Item2;

            return new resSub.VariableValue
            {
                Id = key,
                VariableId = variableId,
                Label = value.Label,
                Rules = value.Rules,
                IsMiscellaneous = (value.Flags?.ContainsKey("miscellaneous") ?? false) && (value.Flags["miscellaneous"].HasValue && value.Flags["miscellaneous"].Value),
                Flags = value.Flags ?? new Dictionary<string, bool?>()
            };
        }
    }
}