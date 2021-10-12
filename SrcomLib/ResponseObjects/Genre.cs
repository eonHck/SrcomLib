using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Genre Object
    /// </summary>
    public class Genre
    {
        /// <summary>
        /// Genre Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Genre Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Links for data related to the Genre to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Genre() { }
    }
}