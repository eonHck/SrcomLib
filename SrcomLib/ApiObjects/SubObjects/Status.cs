using Newtonsoft.Json;
using System;

namespace SrcomLib.ApiObjects.SubObjects
{
    internal class Status
    {
        [JsonProperty("status")]
        public string RunStatus { get; set; }

        [JsonProperty("examiner", NullValueHandling = NullValueHandling.Ignore)]
        public string Examiner { get; set; } = "";

        [JsonProperty("verify-date")]
        public DateTime? VerifyDate { get; set; }

        internal Status() { }
    }
}