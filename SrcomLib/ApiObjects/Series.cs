using Newtonsoft.Json;
using SrcomLib.ApiObjects.ResponseObjects;
using SrcomLib.ApiObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class Series
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("names")]
        public Names Names { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("weblink")]
        public string Weblink { get; set; }

        [JsonIgnore]
        public Dictionary<string, string> Moderators => PrivateModerators.ConvertToType<Dictionary<string, string>>();

        [JsonIgnore]
        public List<User> ModeratorUsers => PrivateModerators.ConvertToType<ApiResponseObject<List<User>>>()?.Data;

        [JsonProperty("moderators")]
        private object PrivateModerators { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("assets")]
        public Assets Assets { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        internal Series() { }
    }
}