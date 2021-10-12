using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Player
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        internal Player() { }
    }
}