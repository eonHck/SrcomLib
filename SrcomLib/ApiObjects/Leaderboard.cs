using Newtonsoft.Json;
using SrcomLib.ApiObjects.ResponseObjects;
using SrcomLib.ApiObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Leaderboard
    {
        [JsonProperty("weblink")]
        public string Weblink { get; set; }

        [JsonIgnore]
        public string GameId => PrivateGame.GetStringValue(Game, nameof(Game.Id));

        [JsonIgnore]
        public Game Game => PrivateGame.ConvertToType<ApiResponseObject<Game>>()?.Data;

        [JsonProperty("game")]
        public object PrivateGame { get; set; }

        [JsonIgnore]
        public string CategoryId => PrivateCategory.GetStringValue(Category, nameof(Category.Id));

        [JsonIgnore]
        public Category Category => PrivateCategory.ConvertToType<ApiResponseObject<Category>>()?.Data;

        [JsonProperty("category")]
        private object PrivateCategory { get; set; }

        [JsonIgnore]
        public string LevelId => PrivateLevel.GetStringValue(Level, nameof(Level.Id));

        [JsonIgnore]
        public Level Level => PrivateLevel.ConvertToType<ApiResponseObject<Level>>()?.Data;

        [JsonProperty("level")]
        private object PrivateLevel { get; set; }

        public string PlatformId => PrivatePlatforms.GetStringValue((Platform)null, nameof(Platform.Id));

        [JsonIgnore]
        public List<Platform> Platforms => PrivatePlatforms.ConvertToType<ApiResponseObject<List<Platform>>>()?.Data;

        [JsonProperty("platform")]
        private object PrivatePlatforms { get; set; }

        [JsonIgnore]
        public string RegionId => PrivateRegions.GetStringValue((Region)null, nameof(Region.Id));

        [JsonIgnore]
        public List<Region> Regions => PrivateRegions.ConvertToType<ApiResponseObject<List<Region>>>()?.Data;

        [JsonProperty("region")]
        private object PrivateRegions { get; set; }

        [JsonProperty("emulators")]
        public bool? Emulators { get; set; }

        [JsonProperty("video-only")]
        public bool VideoOnly { get; set; }

        [JsonProperty("timing")]
        public string Timing { get; set; }

        [JsonProperty("values")]
        public Dictionary<string,string> VariableValues { get; set; }

        [JsonProperty("runs")]
        public List<RunRank> Runs { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonIgnore]
        public List<Player> Players => PrivatePlayers?.Data;

        [JsonProperty("players")]
        private ApiResponseObject<List<Player>> PrivatePlayers { get; set; }

        [JsonIgnore]
        public List<Variable> Variables => PrivateVariables?.Data;

        [JsonProperty("variables")]
        private ApiResponseObject<List<Variable>> PrivateVariables { get; set; }

        internal Leaderboard() { }
    }
}