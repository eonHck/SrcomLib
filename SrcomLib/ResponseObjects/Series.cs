using SrcomLib.ResponseObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Series Object
    /// </summary>
    public class Series
    {
        /// <summary>
        /// Series Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Series Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Series name in Japanese
        /// </summary>
        public string JapaneseName { get; set; }

        /// <summary>
        /// Series Abbreviation
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// URI for accessing the series via a web browser
        /// </summary>
        public Uri Weblink { get; set; }

        /// <summary>
        /// Moderators for this game
        /// </summary>
        public IReadOnlyList<Moderator> Moderators { get; set; }

        /// <summary>
        /// Moderator Users for this game, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<User> ModeratorUsers { get; set; }

        /// <summary>
        /// Date the series was created on speedrun.com
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Assets for the Series
        /// </summary>
        public Assets Assets { get; set; }

        /// <summary>
        /// Links for data related to the Series to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Series() { }
    }
}