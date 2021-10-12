using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class RunRank
    {
        [JsonProperty("place")]
        public int Place { get; set; }
        
        [JsonProperty("run")]
        public Run Run { get; set; }

        internal RunRank() { }
    }
}