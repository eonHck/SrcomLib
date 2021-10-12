using Newtonsoft.Json;
using SrcomLib.ApiObjects.ResponseObjects;
using SrcomLib.ApiObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Run
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("weblink")]
        public string Weblink { get; set; }

        [JsonIgnore]
        public string GameId => PrivateGame.GetStringValue(Game, nameof(Game.Id));

        [JsonIgnore]
        public Game Game => PrivateGame.ConvertToType<ApiResponseObject<Game>>()?.Data;

        [JsonProperty("game")]
        public object PrivateGame { get; set; }

        [JsonIgnore]
        public string LevelId => PrivateLevel.GetStringValue(Level, nameof(Level.Id));

        [JsonIgnore]
        public Level Level => PrivateLevel.ConvertToType<ApiResponseObject<Level>>()?.Data;

        [JsonProperty("level")]
        private object PrivateLevel { get; set; }

        [JsonIgnore]
        public string CategoryId => PrivateCategory.GetStringValue(Category, nameof(Category.Id));

        [JsonIgnore]
        public Category Category => PrivateCategory.ConvertToType<ApiResponseObject<Category>>()?.Data;

        [JsonProperty("category")]
        private object PrivateCategory { get; set; }

        [JsonProperty("videos")]
        public Videos Videos { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonIgnore]
        public List<Player> Players => PrivatePlayers.ConvertToType<List<Player>>();

        [JsonIgnore]
        public List<User> PlayerUsers => PrivatePlayers.ConvertToType<ApiResponseObject<List<User>>>()?.Data;

        [JsonProperty("players")]
        private object PrivatePlayers { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("submitted")]
        public DateTime? Submitted { get; set; }

        [JsonProperty("times")]
        public Times Times { get; set; }

        [JsonProperty("system")]
        public GameSystem System { get; set; }

        [JsonProperty("splits")]
        public Link Splits { get; set; }

        [JsonProperty("values")]
        public Dictionary<string, string> VariableValues { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonIgnore]
        public Region Region { get => RegionEmbed?.Data; }

        [JsonProperty("region")]
        private ApiResponseObject<Region> RegionEmbed {get; set;}

        [JsonIgnore]
        public Platform Platform { get => PlatformEmbed?.Data; }

        [JsonProperty("platform")]
        private ApiResponseObject<Platform> PlatformEmbed { get; set; }

        internal Run() { }
    }
}