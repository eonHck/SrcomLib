using SrcomLib.ApiObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib
{
    internal static class Constants
    {
        internal static IReadOnlyDictionary<Type, List<string>> SupportedEmbeds = new Dictionary<Type, List<string>>
        {
            {
                typeof(Category), new List<string>
                {
                    EmbedNames.Game,
                    EmbedNames.Variables
                }
            },
            {
                typeof(Developer), new List<string> { }
            },
            {
                typeof(Engine), new List<string> { }
            },
            {
                typeof(Game), new List<string>
                {
                    EmbedNames.Categories,
                    EmbedNames.Developers,
                    EmbedNames.Engines,
                    EmbedNames.GameTypes,
                    EmbedNames.Genres,
                    EmbedNames.Levels,
                    EmbedNames.Moderators,
                    EmbedNames.Platforms,
                    EmbedNames.Publishers,
                    EmbedNames.Regions,
                    EmbedNames.Variables
                }
            },
            {
                typeof(GameType), new List<string> { }
            },
            {
                typeof(Genre), new List<string> { }
            },
            {
                typeof(Guest), new List<string> { }
            },
            {
                typeof(Leaderboard), new List<string>
                {
                    EmbedNames.Category,
                    EmbedNames.Game,
                    EmbedNames.Level,
                    EmbedNames.Platforms,
                    EmbedNames.Players,
                    EmbedNames.Regions,
                    EmbedNames.Variables
                }
            },
            {
                typeof(Level), new List<string>
                {
                    EmbedNames.Categories,
                    EmbedNames.Variables
                }
            },
            {
                typeof(PersonalBests), new List<string>
                {
                    EmbedNames.Category,
                    EmbedNames.Game,
                    EmbedNames.Level,
                    EmbedNames.Platform,
                    EmbedNames.Players,
                    EmbedNames.Region
                }
            },
            {
                typeof(Platform), new List<string> { }
            },
            {
                typeof(Publisher), new List<string> { }
            },
            {
                typeof(Region), new List<string> { }
            },
            {
                typeof(Run), new List<string>
                {
                    EmbedNames.Category,
                    EmbedNames.Game,
                    EmbedNames.Level,
                    EmbedNames.Platform,
                    EmbedNames.Players,
                    EmbedNames.Region
                }
            },
            {
                typeof(Series), new List<string>
                {
                    EmbedNames.Moderators
                }
            },
            {
                typeof(User), new List<string> { }
            },
            {
                typeof(Variable), new List<string> { }
            }
        };

        internal static IReadOnlyDictionary<Type, List<string>> SupportedSearchFields = new Dictionary<Type, List<string>>
        {
            {
                typeof(Category), new List<string>
                {
                    SearchFieldNames.SkipEmpty,
                    SearchFieldNames.Top
                }
            },
            {
                typeof(Developer), new List<string> { }
            },
            {
                typeof(Engine), new List<string> { }
            },
            {
                typeof(Game), new List<string>
                {
                    SearchFieldNames.Abbreviation,
                    SearchFieldNames.BulkAccess,
                    SearchFieldNames.DeveloperId,
                    SearchFieldNames.EngineId,
                    SearchFieldNames.GameTypeId,
                    SearchFieldNames.GenreId,
                    SearchFieldNames.ModeratorId,
                    SearchFieldNames.Name,
                    SearchFieldNames.PlatformId,
                    SearchFieldNames.RegionId,
                    SearchFieldNames.ReleaseYear
                }
            },
            {
                typeof(GameType), new List<string> { }
            },
            {
                typeof(Genre), new List<string> { }
            },
            {
                typeof(Guest), new List<string> { }
            },
            {
                typeof(Leaderboard), new List<string>
                {
                    SearchFieldNames.Date,
                    SearchFieldNames.Emulators,
                    SearchFieldNames.PlatformId,
                    SearchFieldNames.RegionId,
                    SearchFieldNames.Timing,
                    SearchFieldNames.Top,
                    SearchFieldNames.Variable,
                    SearchFieldNames.VideoOnly
                }
            },
            {
                typeof(Level), new List<string>
                {
                    SearchFieldNames.Miscellaneous
                }
            },
            {
                typeof(PersonalBests), new List<string> 
                {
                    SearchFieldNames.GameId,
                    SearchFieldNames.SeriesId,
                    SearchFieldNames.Top
                }
            },
            {
                typeof(Platform), new List<string> { }
            },
            {
                typeof(Publisher), new List<string> { }
            },
            {
                typeof(Region), new List<string> { }
            },
            {
                typeof(Run), new List<string>
                {
                    SearchFieldNames.CategoryId,
                    SearchFieldNames.Emulated,
                    SearchFieldNames.ExaminerId,
                    SearchFieldNames.GameId,
                    SearchFieldNames.Guest,
                    SearchFieldNames.LevelId,
                    SearchFieldNames.PlatformId,
                    SearchFieldNames.RegionId,
                    SearchFieldNames.Status,
                    SearchFieldNames.UserId
                }
            },
            {
                typeof(Series), new List<string>
                {
                    SearchFieldNames.Abbreviation,
                    SearchFieldNames.ModeratorId,
                    SearchFieldNames.Name
                }
            },
            {
                typeof(User), new List<string>
                {
                    SearchFieldNames.Hitbox,
                    SearchFieldNames.LookUp,
                    SearchFieldNames.Name,
                    SearchFieldNames.SpeedRunsLive,
                    SearchFieldNames.Twitch,
                    SearchFieldNames.Twitter
                }
            },
            {
                typeof(Variable), new List<string> { }
            }
        };

        internal static IReadOnlyDictionary<Type, List<string>> SupportedSortFields = new Dictionary<Type, List<string>>
        {
            {
                typeof(Category), new List<string>
                {
                    SortFieldNames.Name,
                    SortFieldNames.Mandatory,
                    SortFieldNames.UserDefined,
                    SortFieldNames.Pos
                }
            },
            {
                typeof(Developer), new List<string>
                {
                    SortFieldNames.Name
                }
            },
            {
                typeof(Engine), new List<string>
                {
                    SortFieldNames.Name
                }
            },
            {
                typeof(Game), new List<string>
                {
                    SortFieldNames.Abbreviation,
                    SortFieldNames.Created,
                    SortFieldNames.InternationalName,
                    SortFieldNames.JapaneseName,
                    SortFieldNames.Released,
                    SortFieldNames.Similarity
                }
            },
            {
                typeof(GameType), new List<string>
                {
                    SortFieldNames.Name
                }
            },
            {
                typeof(Genre), new List<string>
                {
                    SortFieldNames.Name
                }
            },
            {
                typeof(Guest), new List<string> { }
            },
            {
                typeof(Leaderboard), new List<string> { }
            },
            {
                typeof(Level), new List<string>
                {
                    SortFieldNames.Miscellaneous,
                    SortFieldNames.Name,
                    SortFieldNames.Pos
                }
            },
            {
                typeof(Platform), new List<string>
                {
                    SortFieldNames.Name,
                    SortFieldNames.Released
                }
            },
            {
                typeof(Publisher), new List<string>
                {
                    SortFieldNames.Name
                }
            },
            {
                typeof(Region), new List<string>
                {
                    SortFieldNames.Name
                }
            },
            {
                typeof(Run), new List<string>
                {
                    SortFieldNames.Category,
                    SortFieldNames.Date,
                    SortFieldNames.Emulated,
                    SortFieldNames.Game,
                    SortFieldNames.Level,
                    SortFieldNames.Platform,
                    SortFieldNames.Region,
                    SortFieldNames.Status,
                    SortFieldNames.Submitted,
                    SortFieldNames.VerifyDate
                }
            },
            {
                typeof(Series), new List<string>
                {
                    SortFieldNames.Abbreviation,
                    SortFieldNames.Created,
                    SortFieldNames.InternationalName,
                    SortFieldNames.JapaneseName
                }
            },
            {
                typeof(User), new List<string>
                {
                    SortFieldNames.InternationalName,
                    SortFieldNames.JapaneseName,
                    SortFieldNames.Role,
                    SortFieldNames.SignUp
                }
            },
            {
                typeof(Variable), new List<string> { }
            }
        };

        internal static IReadOnlyDictionary<Type, string> Endpoints = new Dictionary<Type, string>
        {
            { typeof(Category), "categories" },
            { typeof(Developer), "developers" },
            { typeof(Engine), "engines" },
            { typeof(Game), "games" },
            { typeof(GameType), "gametypes" },
            { typeof(Genre), "genres" },
            { typeof(Guest), "guests" },
            { typeof(Leaderboard), "leaderboards" },
            { typeof(Level), "levels" },
            { typeof(PersonalBests), "" },
            { typeof(Platform), "platforms" },
            { typeof(Publisher), "publishers" },
            { typeof(Region), "regions" },
            { typeof(Run), "runs" },
            { typeof(Series), "series" },
            { typeof(User), "users" },
            { typeof(Variable), "variables" }
        };

        internal static IReadOnlyDictionary<ApiObject, Type> ApiObjectTypeMap = new Dictionary<ApiObject, Type>
        {
            {ApiObject.Category, typeof(Category)},
            {ApiObject.Developer, typeof(Developer)},
            {ApiObject.Engine, typeof(Engine)},
            {ApiObject.Game, typeof(Game)},
            {ApiObject.GameType, typeof(GameType)},
            {ApiObject.Genre, typeof(Genre)},
            {ApiObject.Guest, typeof(Guest)},
            {ApiObject.Leaderboard, typeof(Leaderboard)},
            {ApiObject.Level, typeof(Level)},
            {ApiObject.PersonalBests, typeof(PersonalBests)},
            {ApiObject.Platform, typeof(Platform)},
            {ApiObject.Publisher, typeof(Publisher)},
            {ApiObject.Region, typeof(Region)},
            {ApiObject.Run, typeof(Run)},
            {ApiObject.Series, typeof(Series)},
            {ApiObject.User, typeof(User)},
            {ApiObject.Variable, typeof(Variable)}
        };

        internal static IReadOnlyDictionary<Type, ApiObject> TypeApiObjectMap = new Dictionary<Type, ApiObject>
        {
            {typeof(Category), ApiObject.Category},
            {typeof(Developer), ApiObject.Developer},
            {typeof(Engine), ApiObject.Engine},
            {typeof(Game), ApiObject.Game},
            {typeof(GameType), ApiObject.GameType},
            {typeof(Genre), ApiObject.Genre},
            {typeof(Guest), ApiObject.Guest},
            {typeof(Leaderboard), ApiObject.Leaderboard},
            {typeof(Level), ApiObject.Level},
            {typeof(PersonalBests), ApiObject.PersonalBests},
            {typeof(Platform), ApiObject.Platform},
            {typeof(Publisher), ApiObject.Publisher},
            {typeof(Region), ApiObject.Region},
            {typeof(Run), ApiObject.Run},
            {typeof(Series), ApiObject.Series},
            {typeof(User), ApiObject.User},
            {typeof(Variable), ApiObject.Variable},
        };

        internal static readonly string VariablePrefix = "var-";

        internal struct EmbedNames
        {
            public static string Categories = "categories";
            public static string Category = "category";
            public static string Developers = "developers";
            public static string Engines = "engines";
            public static string Game = "game";
            public static string GameTypes = "gametypes";
            public static string Genres = "genres";
            public static string Level = "level";
            public static string Levels = "levels";
            public static string Moderators = "moderators";
            public static string Platform = "platform";
            public static string Platforms = "platforms";
            public static string Players = "players";
            public static string Publishers = "publishers";
            public static string Region = "region";
            public static string Regions = "regions";
            public static string Variables = "variables";
        }

        internal struct SearchFieldNames
        {
            public static string Abbreviation = "abbreviation";
            public static string BulkAccess = "_bulk";
            public static string CategoryId = "category";
            public static string Date = "date";
            public static string DeveloperId = "developer";
            public static string Emulated = "emulated";
            public static string Emulators = "emulators";
            public static string EngineId = "engine";
            public static string ExaminerId = "examiner";
            public static string GameId = "game";
            public static string GameTypeId = "gametype";
            public static string GenreId = "genre";
            public static string Guest = "guest";
            public static string Hitbox = "hitbox";
            public static string LevelId = "level";
            public static string LookUp = "lookup";
            public static string Miscellaneous = "miscellaneous";
            public static string ModeratorId = "moderator";
            public static string Name = "name";
            public static string PlatformId = "platform";
            public static string PublisherId = "publisher";
            public static string RegionId = "region";
            public static string ReleaseYear = "released";
            public static string SeriesId = "series";
            public static string SkipEmpty = "skip-empty";
            public static string SpeedRunsLive = "speedrunslive";
            public static string Status = "status";
            public static string Timing = "timing";
            public static string Top = "top";
            public static string Twitch = "twitch";
            public static string Twitter = "twitter";
            public static string UserId = "user";
            public static string VideoOnly = "video-only";
            public static string Variable = VariablePrefix;
        }

        internal struct SortFieldNames
        {
            public static string Abbreviation = "abbreviation";
            public static string Category = "category";
            public static string Created = "created";
            public static string Date = "date";
            public static string Emulated = "emulated";
            public static string Game = "game";
            public static string InternationalName = "name.int";
            public static string JapaneseName = "name.jap";
            public static string Level = "level";
            public static string Mandatory = "mandatory";
            public static string Miscellaneous = "miscellaneous";
            public static string Name = "name";
            public static string Platform = "platform";
            public static string Pos = "pos";
            public static string Region = "region";
            public static string Released = "released";
            public static string Role = "role";
            public static string SignUp = "signup";
            public static string Similarity = "similarity";
            public static string Status = "status";
            public static string Submitted = "submitted";
            public static string UserDefined = "user-defined";
            public static string VerifyDate = "verify-date";
        }
    }
}