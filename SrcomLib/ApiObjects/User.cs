using Newtonsoft.Json;
using SrcomLib.ApiObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ApiObjects
{
    internal class User
    {
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; } = "";

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("names")]
        public Names Names { get; set; }

        [JsonProperty("pronouns", NullValueHandling = NullValueHandling.Ignore)]
        public string Pronouns { get; set; } = "";

        [JsonProperty("weblink")]
        public string Weblink { get; set; }

        [JsonProperty("name-style")]
        public NameStyle NameStyle { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("signup")]
        public DateTime Signup { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("twitch")]
        public BasicLink Twitch { get; set; }

        [JsonProperty("hitbox")]
        public BasicLink HitBox { get; set; }

        [JsonProperty("youtube")]
        public BasicLink YouTube { get; set; }

        [JsonProperty("twitter")]
        public BasicLink Twitter { get; set; }

        [JsonProperty("speedrunslive")]
        public BasicLink SpeedRunsLive { get; set; }

        [JsonProperty("assets")]
        public UserAssets Assets { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        internal User() { }
    }
}