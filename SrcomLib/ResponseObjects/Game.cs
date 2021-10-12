using SrcomLib.ResponseObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Game object
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Game Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Game Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Game Name in Japanese
        /// </summary>
        public string JapaneseName { get; set; }

        /// <summary>
        /// Game Abbreviation
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// URI for accessing the game via a web browser
        /// </summary>
        public Uri Weblink { get; set; }

        /// <summary>
        /// Year the game was released
        /// </summary>
        public int? Released { get; set; }

        /// <summary>
        /// Date the game was released
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Game ruleset
        /// </summary>
        public Ruleset Ruleset { get; set; }

        /// <summary>
        /// Is this game a romhack
        /// </summary>
        public bool IsRomhack { get; set; }

        /// <summary>
        /// List of Game Type Ids this game is associated with
        /// </summary>
        public IReadOnlyList<string> GameTypeIds { get; set; }

        /// <summary>
        /// List of Game Types this game is associated with, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<GameType> GameTypes { get; set; }

        /// <summary>
        /// List of Platform Ids this game is associated with
        /// </summary>
        public IReadOnlyList<string> PlatformIds { get; set; }

        /// <summary>
        /// List of Platforms this game is associated with, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Platform> Platforms { get; set; }

        /// <summary>
        /// List of Region Ids this game is associated with
        /// </summary>
        public IReadOnlyList<string> RegionIds { get; set; }

        /// <summary>
        /// List of Regions this game is associated with, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Region> Regions { get; set; }

        /// <summary>
        /// List of Genre Ids this game is associated with
        /// </summary>
        public IReadOnlyList<string> GenreIds { get; set; }

        /// <summary>
        /// List of Genres this game is associated with, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Genre> Genres { get; set; }

        /// <summary>
        /// List of Engine Ids this game is associated with
        /// </summary>
        public IReadOnlyList<string> EngineIds { get; set; }

        /// <summary>
        /// List of Engines this game is associated with, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Engine> Engines { get; set; }

        /// <summary>
        /// List of Developer Ids this game is associated with
        /// </summary>
        public IReadOnlyList<string> DeveloperIds { get; set; }

        /// <summary>
        /// List of Developers this game is associated with, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Developer> Developers { get; set; }

        /// <summary>
        /// List of Publisher Ids this game is associated with
        /// </summary>
        public IReadOnlyList<string> PublisherIds { get; set; }

        /// <summary>
        /// List of Publishers this game is associated with, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Publisher> Publishers { get; set; }

        /// <summary>
        /// Moderators for this game
        /// </summary>
        public IReadOnlyList<Moderator> Moderators { get; set; }

        /// <summary>
        /// Moderator Users for this game, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<User> ModeratorUsers { get; set; }

        /// <summary>
        /// Date the game was created on speedrun.com
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Image assets associated with the game
        /// </summary>
        public Assets Assets { get; set; }

        /// <summary>
        /// Links for data related to the Game to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        /// <summary>
        /// Levels for the game, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Level> Levels { get; set; }

        /// <summary>
        /// Categories for the game, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Category> Categories { get; set; }

        /// <summary>
        /// Variables for the game, null unless embedded in the request
        /// </summary>
        public IReadOnlyList<Variable> Variables { get; set; }

        internal Game() { }
    }
}