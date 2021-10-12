using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System;

namespace SrcomLib.Mapping.Converters
{
    internal class PlayersTypeConverter : ITypeConverter<string, PlayersType>
    {
        public PlayersType Convert(string source, PlayersType destination, ResolutionContext context)
        {
            if (source.Equals("exactly", StringComparison.InvariantCultureIgnoreCase))
            {
                return PlayersType.Exactly;
            }

            return PlayersType.UpTo;
        }
    }
}