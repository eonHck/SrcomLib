using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Publisher Object
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Publisher Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Publisher Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Links for data related to the Publisher to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Publisher() { }
    }
}