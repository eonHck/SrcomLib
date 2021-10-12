using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Game Engine Object
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Engine Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Engine Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Links for data related to the Engine to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Engine() { }
    }
}