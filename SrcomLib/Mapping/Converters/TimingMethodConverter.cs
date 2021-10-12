using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System;

namespace SrcomLib.Mapping.Converters
{
    internal class TimingMethodConverter : ITypeConverter<string, TimingMethod>
    {
        public TimingMethod Convert(string source, TimingMethod destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            if (source.Equals("realtime", StringComparison.InvariantCultureIgnoreCase))
            {
                return TimingMethod.RealTime;
            }

            if (source.Equals("realtime_noloads", StringComparison.InvariantCultureIgnoreCase))
            {
                return TimingMethod.RealTimeWithouLoads;
            }

            if (source.Equals("ingame", StringComparison.InvariantCultureIgnoreCase))
            {
                return TimingMethod.InGameTime;
            }

            throw new ArgumentException(nameof(source));
        }
    }
}