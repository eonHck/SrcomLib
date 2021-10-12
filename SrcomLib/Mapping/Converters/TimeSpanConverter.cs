using AutoMapper;
using System;

namespace SrcomLib.Mapping.Converters
{
    internal class TimeSpanConverter : ITypeConverter<double, TimeSpan>
    {
        public TimeSpan Convert(double source, TimeSpan destination, ResolutionContext context)
        {
            return TimeSpan.FromSeconds(source);
        }
    }
}