using SrcomLib.ResponseObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Speedrun Category object
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Id of the category on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the category on speedrun.com
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URI for accessing the category via a web browser
        /// </summary>
        public Uri Weblink { get; set; }

        /// <summary>
        /// Full game or Level category type
        /// </summary>
        public CategoryType Type { get; set; }

        /// <summary>
        /// Category Rules
        /// </summary>
        public string Rules { get; set; }

        /// <summary>
        /// Describes how many players are allowed for a submission in the category
        /// </summary>
        public Players Players { get; set; }

        /// <summary>
        /// Is this a miscellaneous category
        /// </summary>
        public bool Miscellaneous { get; set; }

        /// <summary>
        /// Links for accessing data related to this category via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        /// <summary>
        /// Game that this cateogry is associated with, null if not included as an embed in the request
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Variables associated with the category, null if not included as an embed in the request
        /// </summary>
        public IReadOnlyList<Variable> Variables { get; set; }

        internal Category() { }
    }
}