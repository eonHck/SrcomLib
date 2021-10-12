using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Platform Object
    /// </summary>
    public class Platform
    {
        /// <summary>
        /// Platform Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Platform Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year the platform was released
        /// </summary>
        public int? Released { get; set; }

        /// <summary>
        /// Links for data related to the Platform to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Platform() { }
    }
}