using System.Collections.Generic;
using res = SrcomLib.ResponseObjects;
using resSub = SrcomLib.ResponseObjects.SubObjects;
using api = SrcomLib.ApiObjects;
using apiSub = SrcomLib.ApiObjects.SubObjects;
using AutoMapper;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class VariableConverter : ITypeConverter<api.Variable, res.Variable>
    {
        public res.Variable Convert(api.Variable source, res.Variable destination, ResolutionContext context)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<string, resSub.ScopeType>().ConvertUsing<ScopeTypeConverter>();
                cfg.CreateMap<List<apiSub.Link>, IReadOnlyList<resSub.Link>>().ConvertUsing<LinkListConverter>();
            });
            var mapper = new Mapper(config);

            return new res.Variable
            {
                Id = source.Id,
                Name = source.Name,
                CategoryId = source.Category,
                ScopeType = mapper.Map<resSub.ScopeType>(source.Scope.Type),
                Mandatory = source.Mandatory,
                UserDefined = source.UserDefined,
                Obsoletes = source.Obsoletes,
                Values = MapVariableValuesToResponse(source.Values, source.Id),
                IsSubCategory = source.IsSubCategory,
                Links = mapper.Map<IReadOnlyList<resSub.Link>>(source.Links)
            };
        }

        private List<resSub.VariableValue> MapVariableValuesToResponse(apiSub.VariableValues variableValues, string variableId)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<(KeyValuePair<string, apiSub.VariableValue>, string), resSub.VariableValue>().ConvertUsing<VariableValueConverter>();
            });
            var mapper = new Mapper(config);

            return variableValues.Values
                .Select(v => mapper.Map<resSub.VariableValue>((v, variableId)))
                .ToList();
        }
    }
}