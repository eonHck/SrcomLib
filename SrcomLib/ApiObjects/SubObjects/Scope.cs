using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Scope
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        internal Scope() { }
    }
}