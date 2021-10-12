using System.Collections.Generic;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Ruleset for a game/category/level
    /// </summary>
    public class Ruleset
    {
        /// <summary>
        /// show milliseconds on the leaderboard
        /// </summary>
        public bool ShowMilliseconds { get; set; }

        /// <summary>
        /// Do runs require verification?
        /// </summary>
        public bool RequireVerification { get; set; }

        /// <summary>
        /// Do runs require a video?
        /// </summary>
        public bool RequireVideo { get; set; }

        /// <summary>
        /// All supported Timing Methods
        /// </summary>
        public IReadOnlyList<TimingMethod> TimingMethods { get; set; }

        /// <summary>
        /// The Default Timing Method
        /// </summary>
        public TimingMethod DefaultTimingMethod { get; set; }

        /// <summary>
        /// Are Emulators allowed?
        /// </summary>
        public bool EmulatorsAllowed { get; set; }

        internal Ruleset() { }
    }
}