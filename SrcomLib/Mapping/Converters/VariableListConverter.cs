using System.Collections.Generic;
using res = SrcomLib.ResponseObjects;
using api = SrcomLib.ApiObjects;
using AutoMapper;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class VariableListConverter : ITypeConverter<List<api.Variable>, IReadOnlyList<res.Variable>>
    {
        public IReadOnlyList<res.Variable> Convert(List<api.Variable> source, IReadOnlyList<res.Variable> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<api.Variable, res.Variable>().ConvertUsing<VariableConverter>();
            });
            var mapper = new Mapper(config);

            return source.Select(i => mapper.Map<res.Variable>(i)).ToList().AsReadOnly();            
        }
    }
}