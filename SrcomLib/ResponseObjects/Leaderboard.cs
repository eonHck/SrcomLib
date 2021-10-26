using SrcomLib.ResponseObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Leaderboard Object
    /// </summary>
    public class Leaderboard
    {
        /// <summary>
        /// URI for accessing the leaderboard via a web browser
        /// </summary>
        public Uri Weblink { get; set; }

        /// <summary>
        /// Game Id for the Leaderboard
        /// </summary>
        public string GameId { get; set; } 

        /// <summary>
        /// Game object for the leaderboard, null unless embedded in the request
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Category Id for the leaderboard
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// Category object for the leaderboard, null unless embedded in the request
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Level Id for the leaderboard, blank for full game categories
        /// </summary>
        public string LevelId { get; set; }

        /// <summary>
        /// Level object for the leaderboard, null unless embedded in the request
        /// </summary>
        public Level Level { get; set; }

        /// <summary>
        /// Platform Id when supplied as a query parameter in the request, null otherwise
        /// </summary>
        public string PlatformId { get; set; }

        /// <summary>
        /// Platforms associated with the leaderboard, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Platform> Platforms { get; set; }

        /// <summary>
        /// Region Id when supplied as a query parameter in the request, null otherwise
        /// </summary>
        public string RegionId { get; set; }

        /// <summary>
        /// Regions associated with the leaderboard, null unless embedded in the request
        /// </summary>
        public List<Region> Regions { get; set; }

        /// <summary>
        /// Emulators boolean when supplied as a query parameter in the request, null otherwise
        /// </summary>
        public bool? Emulators { get; set; }

        /// <summary>
        /// Video Only boolean when supplied as a query parameter in the request, false otherwise
        /// </summary>
        public bool VideoOnly { get; set; }

        /// <summary>
        /// The Timing Method used for the leaderboard
        /// </summary>
        public TimingMethod Timing { get; set; }

        /// <summary>
        /// Variable Values for the leaderboard
        /// </summary>
        public IReadOnlyList<RunVariableValue> VariableValues { get; set; }

        /// <summary>
        /// The runs, by rank on the leaderboard
        /// </summary>
        public IReadOnlyList<RunRank> Runs { get; set; }

        /// <summary>
        /// Links for data related to the Game to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        /// <summary>
        /// List of Players with runs on the leaderboard, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<User> Players { get; set; }

        /// <summary>
        /// Variables associated with the Game and Category/Level, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Variable> Variables { get; set; }

        internal Leaderboard() { }
    }
}