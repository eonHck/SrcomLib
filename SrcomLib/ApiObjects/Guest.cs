using Newtonsoft.Json;
using SrcomLib.ApiObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Guest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        internal Guest() { }
    }
}