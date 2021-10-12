using Newtonsoft.Json;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Videos
    {
        [JsonProperty("links")]
        public List<BasicLink> Links { get; set; }

        internal Videos() { }
    }
}