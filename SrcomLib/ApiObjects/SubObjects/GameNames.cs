using Newtonsoft.Json;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class GameNames : Names
    {
        [JsonProperty("twitch")]
        public string Twitch { get; set; }

        internal GameNames() : base() { }
    }
}