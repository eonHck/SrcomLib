using System;
using resSub = SrcomLib.ResponseObjects.SubObjects;
using apiSub = SrcomLib.ApiObjects.SubObjects;
using AutoMapper;

namespace SrcomLib.Mapping.Converters
{
    internal class TimesConverter : ITypeConverter<apiSub.Times, resSub.Times>
    {
        public resSub.Times Convert(apiSub.Times source, resSub.Times destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<double, TimeSpan>().ConvertUsing<TimeSpanConverter>();
            });

            var mapper = new Mapper(config);

            return new resSub.Times
            {
                Primary = (source.PrimaryT.HasValue && !string.IsNullOrEmpty(source.Primary)) ? (TimeSpan?)mapper.Map<TimeSpan>(source.PrimaryT.Value) : null,
                RealTime = (source.RealTimeT.HasValue && !string.IsNullOrEmpty(source.RealTime)) ? (TimeSpan?)mapper.Map<TimeSpan>(source.RealTimeT.Value) : null,
                RealTimeWithoutLoads = (source.RealTimeNoLoadsT.HasValue && !string.IsNullOrEmpty(source.RealTimeNoLoads)) ? (TimeSpan?)mapper.Map<TimeSpan>(source.RealTimeNoLoadsT.Value) : null,
                InGame = (source.InGameT.HasValue && !string.IsNullOrEmpty(source.InGame)) ? (TimeSpan?)mapper.Map<TimeSpan>(source.InGameT.Value) : null
            };
        }
    }
}