using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Link : BasicLink
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        internal Link() : base() { }
    }
}