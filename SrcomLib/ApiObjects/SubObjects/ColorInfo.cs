using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class ColorInfo
    {
        [JsonProperty("light")]
        public string Light { get; set; }

        [JsonProperty("dark")]
        public string Dark { get; set; }

        internal ColorInfo() { }
    }
}