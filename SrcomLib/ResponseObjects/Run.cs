using SrcomLib.ResponseObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Run Object
    /// </summary>
    public class Run
    {
        /// <summary>
        /// Run Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// URI for accessing the Run via a web browser
        /// </summary>
        public Uri Weblink { get; set; }

        /// <summary>
        /// Game Id for the Run
        /// </summary>
        public string GameId { get; set; }

        /// <summary>
        /// Game Object for the run, null unless embedded in the request
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Level Id for the run, blank for full game runs
        /// </summary>
        public string LevelId { get; set; }

        /// <summary>
        /// Level Object for the run, null unless embedded in the request
        /// </summary>
        public Level Level { get; set; }

        /// <summary>
        /// Category Id for the run
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// Category Object for the run, null unless embedded in the request
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// List of Video direct links associated with the run
        /// </summary>
        public IReadOnlyList<Uri> Videos { get; set; }

        /// <summary>
        /// Comment associated with the run
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Status data for the run
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// List of Players for the run
        /// </summary>
        public IReadOnlyList<Player> Players { get; set; }

        /// <summary>
        /// List of the Players User Objects for the run, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<User> PlayerUsers { get; set; }

        /// <summary>
        /// Date that the run was performed on
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Date that the run was submitted
        /// </summary>
        public DateTime? Submitted { get; set; }

        /// <summary>
        /// Run Times object
        /// </summary>
        public Times Times { get; set; }

        /// <summary>
        /// System the run was played on
        /// </summary>
        public GameSystem System { get; set; }

        /// <summary>
        /// Splits.io link for the run
        /// </summary>
        public Link Splits { get; set; }

        /// <summary>
        /// Variable Values for the run
        /// </summary>
        public IReadOnlyList<RunVariableValue> VariableValues { get; set; }

        /// <summary>
        /// Links for data related to the Run to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        /// <summary>
        /// Region for the run, null unless embedded in the request
        /// </summary>
        public Region Region { get; set; }

        /// <summary>
        /// Platform for the run, null unless embedded in the request
        /// </summary>
        public Platform Platform { get; set; }

        internal Run() { }
    }
}