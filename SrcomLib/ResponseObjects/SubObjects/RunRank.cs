namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Runs that are returned as a part of a leaderboard
    /// </summary>
    public class RunRank
    {
        /// <summary>
        /// The place the run is on the leaderboard
        /// </summary>
        public int Place { get; set; }

        /// <summary>
        /// The Run object itself
        /// </summary>
        public Run Run { get; set; }

        internal RunRank() { }
    }
}