using Newtonsoft.Json;
using SrcomLib.ApiObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Variable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; } = "";

        [JsonProperty("scope")]
        public Scope Scope { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("user-defined")]
        public bool UserDefined { get; set; }

        [JsonProperty("obsoletes")]
        public bool Obsoletes { get; set; }

        [JsonProperty("values")]
        public VariableValues Values { get; set; }

        [JsonProperty("is-subcategory")]
        public bool IsSubCategory { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        internal Variable() { }
    }
}