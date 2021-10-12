using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Assets
    {

        [JsonProperty("logo")]
        public BasicLink Logo { get; set; }

        [JsonProperty("cover-tiny")]
        public BasicLink CoverTiny { get; set; }

        [JsonProperty("cover-small")]
        public BasicLink CoverSmall { get; set; }

        [JsonProperty("cover-medium")]
        public BasicLink CoverMedium { get; set; }

        [JsonProperty("cover-large")]
        public BasicLink CoverLarge { get; set; }

        [JsonProperty("icon")]
        public BasicLink Icon { get; set; }

        [JsonProperty("trophy-1st")]
        public BasicLink Trophy1st { get; set; }

        [JsonProperty("trophy-2nd")]
        public BasicLink Trophy2nd { get; set; }

        [JsonProperty("trophy-3rd")]
        public BasicLink Trophy3rd { get; set; }

        [JsonProperty("trophy-4th")]
        public BasicLink Trophy4th { get; set; }

        [JsonProperty("background")] 
        public BasicLink Background { get; set; }
        
        [JsonProperty("foreground")]
        public BasicLink Foreground { get; set; }

        internal Assets() { }
    }
}