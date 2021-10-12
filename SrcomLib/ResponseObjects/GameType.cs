using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Game Type Object
    /// </summary>
    public class GameType
    {
        /// <summary>
        /// Game Type Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Game Type Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Can this game type have a base game?
        /// </summary>
        public bool AllowsBaseGame { get; set; }

        /// <summary>
        /// Links for data related to the GameType to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal GameType() { }
    }
}