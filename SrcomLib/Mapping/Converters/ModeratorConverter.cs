using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System;

namespace SrcomLib.Mapping.Converters
{
    internal class ModeratorTypeConverter : IValueConverter<string, ModeratorType>
    {
        public ModeratorType Convert(string sourceMember, ResolutionContext context)
        {
            if (sourceMember.Equals("moderator", StringComparison.InvariantCultureIgnoreCase))
            {
                return ModeratorType.Moderator;
            }

            if (sourceMember.Equals("super-moderator", StringComparison.InvariantCultureIgnoreCase))
            {
                return ModeratorType.SuperModerator;
            }

            throw new ArgumentException(nameof(sourceMember));
        }
    }
}