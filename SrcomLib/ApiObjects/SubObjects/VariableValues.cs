using Newtonsoft.Json;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class VariableValues
    {
        [JsonProperty("_note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; } = "";
        
        [JsonProperty("choices")]
        public Dictionary<string, string> Choices { get; set; }

        [JsonProperty("values")]
        public Dictionary<string, VariableValue> Values { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public string Default { get; set; } = "";

        internal VariableValues() { }
    }
}