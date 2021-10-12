using Newtonsoft.Json;
using SrcomLib.ApiObjects.ResponseObjects;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class PersonalBests
    {
        [JsonProperty("place")]
        public int Place { get; set; }

        [JsonProperty("run")]
        public Run Run { get; set; }

        [JsonIgnore]
        public Game Game => PrivateGame?.Data;

        [JsonProperty("game")]
        private ApiResponseObject<Game> PrivateGame { get; set; }

        [JsonIgnore]
        public Category Category => PrivateCategory?.Data;

        [JsonProperty("category")]
        private ApiResponseObject<Category> PrivateCategory { get; set; }

        [JsonIgnore]
        public Level Level => PrivateLevel.ConvertToType<ApiResponseObject<Level>>()?.Data;

        [JsonProperty("level")]
        private object PrivateLevel { get; set; }

        [JsonIgnore]
        public List<User> PlayerUsers => PrivatePlayerUsers?.Data;

        [JsonProperty("players")]
        private ApiResponseObject<List<User>> PrivatePlayerUsers { get; set; }

        [JsonIgnore]
        public Region Region => PrivateRegion?.Data;

        [JsonProperty("region")]
        private ApiResponseObject<Region> PrivateRegion { get; set; }

        [JsonIgnore]
        public Platform Platform => PrivatePlatform?.Data;

        [JsonProperty("platform")]
        private ApiResponseObject<Platform> PrivatePlatform { get; set; }

        internal PersonalBests() { }
    }
}