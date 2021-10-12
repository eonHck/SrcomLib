namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Describes the number of players for a category
    /// </summary>
    public class Players
    {
        /// <summary>
        /// Players Type
        /// </summary>
        public PlayersType Type { get; set; }

        /// <summary>
        /// Number of players
        /// </summary>
        public int Value { get; set; }

        internal Players() { }
    }
}