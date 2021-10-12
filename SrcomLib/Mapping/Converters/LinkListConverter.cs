using System;
using System.Collections.Generic;
using resSub = SrcomLib.ResponseObjects.SubObjects;
using apiSub = SrcomLib.ApiObjects.SubObjects;
using AutoMapper;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class LinkListConverter : ITypeConverter<List<apiSub.Link>, IReadOnlyList<resSub.Link>>
    {
        public IReadOnlyList<resSub.Link> Convert(List<apiSub.Link> source, IReadOnlyList<resSub.Link> destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<string, Uri>().ConvertUsing<UriStringConverter>();
                cfg.CreateMap<apiSub.Link, resSub.Link>();
            });
            var mapper = new Mapper(config);

            return source.Select(i => mapper.Map<resSub.Link>(i)).ToList().AsReadOnly();
        }
    }
}