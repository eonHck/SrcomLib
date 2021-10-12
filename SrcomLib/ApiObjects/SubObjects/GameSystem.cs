using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class GameSystem
    {
        [JsonProperty("platform")]
        public string PlatformId { get; set; }

        [JsonProperty("emulated")]
        public bool Emulated { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; } = "";

        internal GameSystem() { }
    }
}