using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Game Developer Object
    /// </summary>
    public class Developer
    {
        /// <summary>
        /// Developer Id on speedrun.com
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Developer name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Links for data related to the Developer to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Developer() { }
    }
}