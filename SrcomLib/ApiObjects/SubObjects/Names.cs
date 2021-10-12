using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Names
    {
        [JsonProperty("international")]
        public string International { get; set; }

        [JsonProperty("japanese")]
        public string Japanese { get; set; }

        internal Names() { }
    }
}