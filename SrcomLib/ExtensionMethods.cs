using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib
{
    internal static class ExtensionMethods
    {
        internal static void Set<T>(this MemoryCache cache, object key, T value, TimeSpan absoluteExpirationRelativeToNow, bool ignoreCache)
        {
            if (ignoreCache) return;
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSize(1)
                .SetSlidingExpiration(absoluteExpirationRelativeToNow);
            cache.Set(key, value, cacheEntryOptions);
        }

        internal static bool TryGetValue<T>(this MemoryCache cache, object key, out T value, bool ignoreCache)
        {
            value = default;
            if (ignoreCache) return false;
            return cache.TryGetValue(key, out value);
        }

        internal static bool Contains(this IEnumerable<string> list, string value, StringComparison comparisonType)
        {
            return list.Any(s => s.Equals(value, comparisonType));
        }

        internal static bool ContainsElement<T>(this IReadOnlyDictionary<T, List<string>> dictionary, T key, string valueElement, StringComparison comparisonType, bool handleVariables = false)
        {
            if (!dictionary.ContainsKey(key)) return false;

            if (handleVariables && valueElement.StartsWith(Constants.VariablePrefix))
            {
                return dictionary[key].Contains(Constants.VariablePrefix, comparisonType);
            }

            return dictionary[key].Contains(valueElement, comparisonType);
        }

        internal static void AddOrUpdate<T, U>(this IDictionary<T, U> dictionary, T key, U value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
                return;
            }
            dictionary.Add(key, value);
        }

        internal static Type TryGetKeyFromValue(this IReadOnlyDictionary<Type, string> dictionary, string value, StringComparison comparisonType)
        {
            var item = dictionary.Where(kvp => kvp.Value.Equals(value, comparisonType)).FirstOrDefault();
            if (item.Equals(default(KeyValuePair<Type, string>)))
            {
                return default;
            }
            return item.Key;
        }

        internal static void AddUnique(this IList<string> list, string value, StringComparison comparisonType)
        {
            if (list.Contains(value, comparisonType)) return;

            list.Add(value);
        }

        internal static T ConvertToType<T>(this object obj)
        {
            if (obj is null || obj is string)
            {
                return default;
            }
            try
            {
                return obj is JArray array ? array.ToObject<T>() : ((JObject)obj).ToObject<T>();
            }
            catch (Exception)
            {
                return default;
            }
        }

        internal static string GetStringValue<T>(this object obj, T fallbackObject, string fallbackField) where T : class
        {
            if (obj is string)
            {
                return obj.ToString();
            }

            if (fallbackObject is null)
            {
                return string.Empty;
            }

            try
            {
                var property = typeof(T).GetProperties().Where(i => i.Name.Equals(fallbackField, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                return !(property is null) ? property.GetValue(fallbackObject).ToString() : string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal static List<Embed> ToBaseEmbedList(this List<CategoryEmbed> list)
        {
            return list.Select(e => (Embed)e).ToList();
        }

        internal static List<Embed> ToBaseEmbedList(this List<GameEmbed> list)
        {
            return list.Select(e => (Embed)e).ToList();
        }

        internal static List<Embed> ToBaseEmbedList(this List<LeaderboardEmbed> list)
        {
            return list.Select(e => (Embed)e).ToList();
        }

        internal static List<Embed> ToBaseEmbedList(this List<LevelEmbed> list)
        {
            return list.Select(e => (Embed)e).ToList();
        }

        internal static List<Embed> ToBaseEmbedList(this List<PersonalBestsEmbed> list)
        {
            return list.Select(e => (Embed)e).ToList();
        }

        internal static List<Embed> ToBaseEmbedList(this List<RunEmbed> list)
        {
            return list.Select(e => (Embed)e).ToList();
        }

        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<CategorySearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }

        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<GameSearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }
        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<LeaderboardSearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }

        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<LevelSearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }

        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<PersonalBestsSearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }

        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<RunSearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }

        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<SeriesSearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }

        internal static IDictionary<SearchField, string> ToBaseSearchDictionary(this IDictionary<UserSearchField, string> dictionary)
        {
            return dictionary.ToDictionary(e => (SearchField)e.Key, e => e.Value);
        }

        internal static string GetStringValue(this Embed embed)
        {
            switch (embed)
            {
                case Embed.Categories:
                    return Constants.EmbedNames.Categories;
                case Embed.Category:
                    return Constants.EmbedNames.Category;
                case Embed.Developers:
                    return Constants.EmbedNames.Developers;
                case Embed.Engines:
                    return Constants.EmbedNames.Engines;
                case Embed.Game:
                    return Constants.EmbedNames.Game;
                case Embed.GameTypes:
                    return Constants.EmbedNames.GameTypes;
                case Embed.Genres:
                    return Constants.EmbedNames.Genres;
                case Embed.Level:
                    return Constants.EmbedNames.Level;
                case Embed.Levels:
                    return Constants.EmbedNames.Levels;
                case Embed.Moderators:
                    return Constants.EmbedNames.Moderators;
                case Embed.Platform:
                    return Constants.EmbedNames.Platform;
                case Embed.Platforms:
                    return Constants.EmbedNames.Platforms;
                case Embed.Players:
                    return Constants.EmbedNames.Players;
                case Embed.Publishers:
                    return Constants.EmbedNames.Publishers;
                case Embed.Region:
                    return Constants.EmbedNames.Region;
                case Embed.Regions:
                    return Constants.EmbedNames.Regions;
                case Embed.Variables:
                    return Constants.EmbedNames.Variables;
                default:
                    throw new ArgumentOutOfRangeException(nameof(embed));
            }
        }

        internal static string GetStringValue(this SearchField searchField)
        {
            switch (searchField)
            {
                case SearchField.Abbreviation:
                    return Constants.SearchFieldNames.Abbreviation;
                case SearchField.BulkAccess:
                    return Constants.SearchFieldNames.BulkAccess;
                case SearchField.CategoryId:
                    return Constants.SearchFieldNames.CategoryId;
                case SearchField.Date:
                    return Constants.SearchFieldNames.Date;
                case SearchField.DeveloperId:
                    return Constants.SearchFieldNames.DeveloperId;
                case SearchField.Emulated:
                    return Constants.SearchFieldNames.Emulated;
                case SearchField.Emulators:
                    return Constants.SearchFieldNames.Emulators;
                case SearchField.EngineId:
                    return Constants.SearchFieldNames.EngineId;
                case SearchField.ExaminerId:
                    return Constants.SearchFieldNames.ExaminerId;
                case SearchField.GameId:
                    return Constants.SearchFieldNames.GameId;
                case SearchField.GameTypeId:
                    return Constants.SearchFieldNames.GameTypeId;
                case SearchField.GenreId:
                    return Constants.SearchFieldNames.GenreId;
                case SearchField.Guest:
                    return Constants.SearchFieldNames.Guest;
                case SearchField.Hitbox:
                    return Constants.SearchFieldNames.Hitbox;
                case SearchField.LevelId:
                    return Constants.SearchFieldNames.LevelId;
                case SearchField.LookUp:
                    return Constants.SearchFieldNames.LookUp;
                case SearchField.Miscellaneous:
                    return Constants.SearchFieldNames.Miscellaneous;
                case SearchField.ModeratorId:
                    return Constants.SearchFieldNames.ModeratorId;
                case SearchField.Name:
                    return Constants.SearchFieldNames.Name;
                case SearchField.PlatformId:
                    return Constants.SearchFieldNames.PlatformId;
                case SearchField.PublisherId:
                    return Constants.SearchFieldNames.PublisherId;
                case SearchField.RegionId:
                    return Constants.SearchFieldNames.RegionId;
                case SearchField.ReleaseYear:
                    return Constants.SearchFieldNames.ReleaseYear;
                case SearchField.SeriesId:
                    return Constants.SearchFieldNames.SeriesId;
                case SearchField.SkipEmpty:
                    return Constants.SearchFieldNames.SkipEmpty;
                case SearchField.SpeedRunsLive:
                    return Constants.SearchFieldNames.SpeedRunsLive;
                case SearchField.Status:
                    return Constants.SearchFieldNames.Status;
                case SearchField.Timing:
                    return Constants.SearchFieldNames.Timing;
                case SearchField.Top:
                    return Constants.SearchFieldNames.Top;
                case SearchField.Twitch:
                    return Constants.SearchFieldNames.Twitch;
                case SearchField.Twitter:
                    return Constants.SearchFieldNames.Twitter;
                case SearchField.UserId:
                    return Constants.SearchFieldNames.UserId;
                case SearchField.VideoOnly:
                    return Constants.SearchFieldNames.VideoOnly;
                default:
                    throw new ArgumentOutOfRangeException(nameof(searchField));
            }
        }

        internal static string GetStringValue(this SortField sortField)
        {
            switch (sortField)
            {
                case SortField.Abbreviation:
                    return Constants.SortFieldNames.Abbreviation;
                case SortField.Category:
                    return Constants.SortFieldNames.Category;
                case SortField.Created:
                    return Constants.SortFieldNames.Created;
                case SortField.Date:
                    return Constants.SortFieldNames.Date;
                case SortField.Emulated:
                    return Constants.SortFieldNames.Emulated;
                case SortField.Game:
                    return Constants.SortFieldNames.Game;
                case SortField.InternationalName:
                    return Constants.SortFieldNames.InternationalName;
                case SortField.JapaneseName:
                    return Constants.SortFieldNames.JapaneseName;
                case SortField.Level:
                    return Constants.SortFieldNames.Level;
                case SortField.Mandatory:
                    return Constants.SortFieldNames.Mandatory;
                case SortField.Miscellaneous:
                    return Constants.SortFieldNames.Miscellaneous;
                case SortField.Name:
                    return Constants.SortFieldNames.Name;
                case SortField.Platform:
                    return Constants.SortFieldNames.Platform;
                case SortField.Pos:
                    return Constants.SortFieldNames.Pos;
                case SortField.Region:
                    return Constants.SortFieldNames.Region;
                case SortField.Released:
                    return Constants.SortFieldNames.Released;
                case SortField.Role:
                    return Constants.SortFieldNames.Role;
                case SortField.SignUp:
                    return Constants.SortFieldNames.SignUp;
                case SortField.Similarity:
                    return Constants.SortFieldNames.Similarity;
                case SortField.Status:
                    return Constants.SortFieldNames.Status;
                case SortField.Submitted:
                    return Constants.SortFieldNames.Submitted;
                case SortField.UserDefined:
                    return Constants.SortFieldNames.UserDefined;
                case SortField.VerifyDate:
                    return Constants.SortFieldNames.VerifyDate;
                default:
                    throw new ArgumentOutOfRangeException(nameof(sortField));
            }
        }
    }
}