using Newtonsoft.Json;
using SrcomLib.ApiObjects.ResponseObjects;
using SrcomLib.ApiObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Category
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("weblink")]
        public string Weblink { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("rules")]
        public string Rules { get; set; }
        
        [JsonProperty("players")]
        public Players Players { get; set; }
        
        [JsonProperty("miscellaneous")]
        public bool Miscellaneous { get; set; }
        
        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonIgnore]
        public Game Game => PrivateGame?.Data; 

        [JsonProperty("game")]
        private ApiResponseObject<Game> PrivateGame { get; set; }

        [JsonIgnore]
        public List<Variable> Variables => PrivateVariables?.Data; 

        [JsonProperty("variables")]
        private ApiResponseObject<List<Variable>> PrivateVariables { get; set; }

        internal Category() { }
    }
}