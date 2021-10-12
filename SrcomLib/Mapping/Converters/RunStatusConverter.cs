using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System;

namespace SrcomLib.Mapping.Converters
{
    internal class RunStatusConverter : ITypeConverter<string, RunStatus>
    {
        public RunStatus Convert(string source, RunStatus destination, ResolutionContext context)
        {
            if (source.Equals("new", StringComparison.InvariantCultureIgnoreCase))
            {
                return RunStatus.New;
            }

            if (source.Equals("verified", StringComparison.InvariantCultureIgnoreCase))
            {
                return RunStatus.Verified;
            }

            if (source.Equals("rejected", StringComparison.InvariantCultureIgnoreCase))
            {
                return RunStatus.Rejected;
            }

            throw new ArgumentException(nameof(source));
        }
    }
}