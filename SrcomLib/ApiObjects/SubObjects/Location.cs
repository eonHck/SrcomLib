using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Location
    {
        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("region")]
        public Region Region { get; set; }

        internal Location() { }
    }
}