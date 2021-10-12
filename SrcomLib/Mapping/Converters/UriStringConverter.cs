using AutoMapper;
using System;

namespace SrcomLib.Mapping.Converters
{
    internal class UriStringConverter : ITypeConverter<string, Uri>
    {
        public Uri Convert(string source, Uri destination, ResolutionContext context)
        {
            try
            {
                return new Uri(source);
            }
            catch
            {
                return default;
            }
        }
    }
}