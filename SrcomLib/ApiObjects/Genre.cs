using Newtonsoft.Json;
using SrcomLib.ApiObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Genre
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        internal Genre() { }
    }
}