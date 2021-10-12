using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Times
    {
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public string Primary { get; set; } = "";

        [JsonProperty("primary_t")]
        public double? PrimaryT { get; set; }

        [JsonProperty("realtime", NullValueHandling = NullValueHandling.Ignore)]
        public string RealTime { get; set; } = "";

        [JsonProperty("realtime_t")]
        public double? RealTimeT { get; set; }

        [JsonProperty("realtime_noloads", NullValueHandling = NullValueHandling.Ignore)]
        public string RealTimeNoLoads { get; set; } = "";

        [JsonProperty("realtime_noloads_t")]
        public double? RealTimeNoLoadsT { get; set; }

        [JsonProperty("ingame", NullValueHandling = NullValueHandling.Ignore)]
        public string InGame { get; set; } = "";

        [JsonProperty("ingame_t")]
        public double? InGameT { get; set; }

        internal Times() { }
    }
}