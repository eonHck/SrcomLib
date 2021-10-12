using SrcomLib.ResponseObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Level Object
    /// </summary>
    public class Level
    {
        /// <summary>
        /// Level Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the Level
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URI for accessing the level via a web browser
        /// </summary>
        public Uri Weblink { get; set; }

        /// <summary>
        /// Rules for the Level
        /// </summary>
        public string Rules { get; set; }

        /// <summary>
        /// Links for data related to the Level to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        /// <summary>
        /// List of Categories associated with the Level, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Category> Categories { get; set; }

        /// <summary>
        /// List of Variables associated with the Level, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Variable> Variables { get; set; }

        internal Level() { }

    }
}