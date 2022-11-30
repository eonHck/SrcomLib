using System;
using System.Collections.Generic;
using res = SrcomLib.ResponseObjects;
using resSub = SrcomLib.ResponseObjects.SubObjects;
using api = SrcomLib.ApiObjects;
using apiSub = SrcomLib.ApiObjects.SubObjects;
using AutoMapper;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class CategoryListConverter : ITypeConverter<List<api.Category>, IReadOnlyList<res.Category>>
    {
        public IReadOnlyList<res.Category> Convert(List<api.Category> source, IReadOnlyList<res.Category> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<api.Category, res.Category>();
                cfg.CreateMap<api.Game, res.Game>();
                cfg.CreateMap<apiSub.Players, resSub.Players>();

                cfg.CreateMap<string, Uri>().ConvertUsing<UriStringConverter>();
                cfg.CreateMap<List<apiSub.Link>, IReadOnlyList<resSub.Link>>().ConvertUsing<LinkListConverter>();
                cfg.CreateMap<string, resSub.CategoryType>().ConvertUsing<CategoryTypeConverter>();
                cfg.CreateMap<List<api.Variable>, IReadOnlyList<res.Variable>>().ConvertUsing<VariableListConverter>();
                cfg.CreateMap<string, resSub.PlayersType>().ConvertUsing<PlayersTypeConverter>();
            });
            var mapper = new Mapper(config);

            return source.Select(i => mapper.Map<res.Category>(i)).ToList().AsReadOnly();
        }
    }
}
