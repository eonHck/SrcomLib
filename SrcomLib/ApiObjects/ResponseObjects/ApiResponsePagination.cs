using Newtonsoft.Json;
using SrcomLib.ApiObjects.SubObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SrcomLib.ApiObjects.ResponseObjects
{
    internal class ApiResponsePagination
    {
        private const string NextLinkRel = "next";
        private const string PreviousLinkRel = "prev";

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
        
        [JsonProperty("size")]
        public int Size { get; set; }
        
        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        private bool HasLink(string key) => Links.Any(l => l.Rel.Equals(key, StringComparison.OrdinalIgnoreCase));
        private string GetLink(string key) => Links.FirstOrDefault(l => l.Rel.Equals(key, StringComparison.OrdinalIgnoreCase)).Uri;
        private bool TryGetLink(string key, out Uri uri)
        {
            uri = null;
            if (!HasLink(key)) return false;

            uri = new Uri(GetLink(key));
            return true;
        }

        public bool TryGetNextUri(out Uri uri) => TryGetLink(NextLinkRel, out uri);
        public bool TryGetPreviousUri(out Uri uri) => TryGetLink(PreviousLinkRel, out uri);
    }
}