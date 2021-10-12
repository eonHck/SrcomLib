using AutoMapper;
using SrcomLib.ResponseObjects.SubObjects;
using System;

namespace SrcomLib.Mapping.Converters
{
    class UserRoleConverter : ITypeConverter<string, UserRole>
    {
        public UserRole Convert(string source, UserRole destination, ResolutionContext context)
        {
            if (source is null)
            {
                return default;
            }

            if (source.Equals("banned", StringComparison.InvariantCultureIgnoreCase))
            {
                return UserRole.Banned;
            }

            if (source.Equals("user", StringComparison.InvariantCultureIgnoreCase))
            {
                return UserRole.User;
            }

            if (source.Equals("trusted", StringComparison.InvariantCultureIgnoreCase))
            {
                return UserRole.Trusted;
            }

            if (source.Equals("moderator", StringComparison.InvariantCultureIgnoreCase))
            {
                return UserRole.Moderator;
            }

            if (source.Equals("admin", StringComparison.InvariantCultureIgnoreCase))
            {
                return UserRole.Admin;
            }

            if (source.Equals("programmer", StringComparison.InvariantCultureIgnoreCase))
            {
                return UserRole.Programmer;
            }

            throw new ArgumentException(nameof(source));
        }
    }
}