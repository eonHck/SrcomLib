using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Region Object
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Region Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Region Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Links for data related to the Region to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Region() { }
    }
}