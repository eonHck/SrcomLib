using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System;

namespace SrcomLib.Mapping.Converters
{
    internal class CategoryTypeConverter : ITypeConverter<string, CategoryType>
    {
        public CategoryType Convert(string source, CategoryType destination, ResolutionContext context)
        {
            if (source.Equals("per-game", StringComparison.InvariantCultureIgnoreCase))
            {
                return CategoryType.PerGame;
            }

            return CategoryType.PerLevel;
        }
    }
}