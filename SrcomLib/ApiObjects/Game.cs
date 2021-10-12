using Newtonsoft.Json;
using SrcomLib.ApiObjects.ResponseObjects;
using SrcomLib.ApiObjects.SubObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib.ApiObjects
{
    internal class Game
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("names")]
        public GameNames Names { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("weblink")]
        public string Weblink { get; set; }

        [JsonProperty("released")]
        public int? Released { get; set; }

        [JsonProperty("release-date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("ruleset")]
        public Ruleset Ruleset { get; set; }

        [JsonProperty("romhack")]
        public bool Romhack { get; set; }

        [JsonIgnore]
        public List<string> GameTypeIds => GameTypes?.Select(i => i.Id).ToList() ?? PrivateGameTypes.ConvertToType<List<string>>();

        [JsonIgnore]
        public List<GameType> GameTypes => PrivateGameTypes.ConvertToType<ApiResponseObject<List<GameType>>>()?.Data;

        [JsonProperty("gametypes")]
        private object PrivateGameTypes { get; set; }

        [JsonIgnore]
        public List<string> PlatformIds => Platforms?.Select(i => i.Id).ToList() ?? PrivatePlatforms.ConvertToType<List<string>>();

        [JsonIgnore]
        public List<Platform> Platforms => PrivatePlatforms.ConvertToType<ApiResponseObject<List<Platform>>>()?.Data;

        [JsonProperty("platforms")]
        public object PrivatePlatforms { get; set; }

        [JsonIgnore]
        public List<string> RegionIds => Regions?.Select(i => i.Id).ToList() ?? PrivateRegions.ConvertToType<List<string>>();

        [JsonIgnore]
        public List<Region> Regions => PrivateRegions.ConvertToType<ApiResponseObject<List<Region>>>()?.Data;

        [JsonProperty("regions")]
        private object PrivateRegions { get; set; }

        [JsonIgnore]
        public List<string> GenreIds => Genres?.Select(i => i.Id).ToList() ?? PrivateGenres.ConvertToType<List<string>>();

        [JsonIgnore]
        public List<Genre> Genres => PrivateGenres.ConvertToType<ApiResponseObject<List<Genre>>>()?.Data;

        [JsonProperty("genres")]
        private object PrivateGenres { get; set; }

        [JsonIgnore]
        public List<string> EngineIds => Engines?.Select(i => i.Id).ToList() ?? PrivateEngines.ConvertToType<List<string>>();

        [JsonIgnore]
        public List<Engine> Engines => PrivateEngines.ConvertToType<ApiResponseObject<List<Engine>>>()?.Data;

        [JsonProperty("engines")]
        private object PrivateEngines { get; set; }

        [JsonIgnore]
        public List<string> DeveloperIds => Developers?.Select(i => i.Id).ToList() ?? PrivateDevelopers.ConvertToType<List<string>>();

        [JsonIgnore]
        public List<Developer> Developers => PrivateDevelopers.ConvertToType<ApiResponseObject<List<Developer>>>()?.Data;

        [JsonProperty("developers")]
        private object PrivateDevelopers { get; set; }

        [JsonIgnore]
        public List<string> PublisherIds => Publishers?.Select(i => i.Id).ToList() ?? PrivatePublishers.ConvertToType<List<string>>();

        [JsonIgnore]
        public List<Publisher> Publishers => PrivatePublishers.ConvertToType<ApiResponseObject<List<Publisher>>>()?.Data;

        [JsonProperty("publishers")]
        private object PrivatePublishers { get; set; }

        [JsonIgnore]
        public Dictionary<string, string> Moderators => PrivateModerators.ConvertToType<Dictionary<string, string>>();

        [JsonIgnore]
        public List<User> ModeratorUsers => PrivateModerators.ConvertToType<ApiResponseObject<List<User>>>()?.Data;

        [JsonProperty("moderators")]
        private object PrivateModerators { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("assets")]
        public Assets Assets { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonIgnore]
        public List<Level> Levels => PrivateLevels?.Data;

        [JsonProperty("levels")]
        private ApiResponseObject<List<Level>> PrivateLevels { get; set; }

        [JsonIgnore]
        public List<Category> Categories => PrivateCategories?.Data;

        [JsonProperty("categories")]
        private ApiResponseObject<List<Category>> PrivateCategories { get; set; }

        [JsonIgnore]
        public List<Variable> Variables => PrivateVariables?.Data;

        [JsonProperty("variables")]
        private ApiResponseObject<List<Variable>> PrivateVariables { get; set; }
        
        internal Game() { }
    }
}