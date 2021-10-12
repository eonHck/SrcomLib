using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Players
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        internal Players() { }
    }
}