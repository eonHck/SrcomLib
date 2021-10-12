using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Guest Object
    /// </summary>
    public class Guest
    {
        /// <summary>
        /// Guest Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Links for data related to the Guest to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Guest() { }
    }
}