using AutoMapper;
using SrcomLib.ApiObjects.SubObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib.Mapping.Converters
{
    internal class VideosConverter : ITypeConverter<Videos, IReadOnlyList<Uri>>
    {
        public IReadOnlyList<Uri> Convert(Videos source, IReadOnlyList<Uri> destination, ResolutionContext context)
        {
            if (source is null || source.Links is null)
            {
                return default;
            }
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BasicLink, Uri>().ConvertUsing<UriBasicLinkConverter>();
            });

            var mapper = new Mapper(config);

            return source.Links
                .Select(i => mapper.Map<Uri>(i))
                .ToList()
                .AsReadOnly();
        }
    }
}
