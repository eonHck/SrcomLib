using Newtonsoft.Json;
using SrcomLib.ApiObjects.ResponseObjects;
using SrcomLib.ApiObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Level
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weblink")]
        public string Weblink { get; set; }

        [JsonProperty("rules")]
        public string Rules { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonIgnore]
        public List<Category> Categories => PrivateCategories?.Data;

        [JsonProperty("categories")]
        private ApiResponseObject<List<Category>> PrivateCategories { get; set; }

        [JsonIgnore]
        public List<Variable> Variables => PrivateVariables?.Data;

        [JsonProperty("variables")]
        private ApiResponseObject<List<Variable>> PrivateVariables { get; set; }

        internal Level() { }
    }
}