using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class UserAssets
    {
        [JsonProperty("icon")]
        public BasicLink Icon { get; set; }

        [JsonProperty("image")]
        public BasicLink Image { get; set; }

        internal UserAssets() { }
    }
}