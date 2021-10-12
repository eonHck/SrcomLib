using System;
using AutoMapper;
using SrcomLib.ApiObjects.SubObjects;

namespace SrcomLib.Mapping.Converters
{
    internal class UriBasicLinkConverter : ITypeConverter<BasicLink, Uri>
    {
        public Uri Convert(BasicLink source, Uri destination, ResolutionContext context)
        {
            if (source is null) 
            { 
                return default; 
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<string, Uri>().ConvertUsing<UriStringConverter>();
            });
            var mapper = new Mapper(config);

            return mapper.Map<Uri>(source.Uri);
        }
    }
}