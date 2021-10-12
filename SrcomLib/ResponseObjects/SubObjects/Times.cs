using System;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Times for a run
    /// </summary>
    public class Times
    {
        /// <summary>
        /// Primary Time, this is the timing method that matches the default timing method for the ruleset
        /// </summary>
        public TimeSpan? Primary { get; set; }

        /// <summary>
        /// Run time in Real Time
        /// </summary>
        public TimeSpan? RealTime { get; set; }

        /// <summary>
        /// Run time in Real Time with loads removed
        /// </summary>
        public TimeSpan? RealTimeWithoutLoads { get; set; }

        /// <summary>
        /// Run Time using the In Game time
        /// </summary>
        public TimeSpan? InGame { get; set; }

        internal Times() { }
    }
}