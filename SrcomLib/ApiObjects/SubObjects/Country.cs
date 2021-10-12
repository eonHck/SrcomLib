using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Country
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("names")]
        public Names Names { get; set; }

        internal Country() { }
    }
}