using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System;


namespace SrcomLib.Mapping.Converters
{
    internal class ScopeTypeConverter : ITypeConverter<string, ScopeType>
    {
        public ScopeType Convert(string source, ScopeType destination, ResolutionContext context)
        {
            if (source.Equals("global", StringComparison.InvariantCultureIgnoreCase))
            {
                return ScopeType.Global;
            }

            if (source.Equals("full-game", StringComparison.InvariantCultureIgnoreCase))
            {
                return ScopeType.FullGame;
            }

            if (source.Equals("all-levels", StringComparison.InvariantCultureIgnoreCase))
            {
                return ScopeType.AllLevels;
            }

            if (source.Equals("single-level", StringComparison.InvariantCultureIgnoreCase))
            {
                return ScopeType.SingleLevel;
            }

            throw new ArgumentException(nameof(source));
        }
    }
}