using System;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Player object on Runs
    /// </summary>
    public class Player
    {
        /// <summary>
        /// user or guest
        /// </summary>
        public string Rel { get; set; }

        /// <summary>
        /// User Id for a User, Name for a Guest
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Link to the player
        /// </summary>
        public Uri Uri { get; set; }

        internal Player() { }
    }
}