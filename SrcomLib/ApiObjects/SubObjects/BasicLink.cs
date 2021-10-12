using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class BasicLink
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        internal BasicLink() { }
    }
}