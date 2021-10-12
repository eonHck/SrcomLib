using Newtonsoft.Json;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class VariableValue
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public string Rules { get; set; } = "";

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool?> Flags { get; set; }

        internal VariableValue() { }
    }
}