using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class NameStyle
    {
        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("color-from")]
        public ColorInfo ColorFrom { get; set; }

        [JsonProperty("color-to")]
        public ColorInfo ColorTo { get; set; }

        internal NameStyle() { }
    }
}