namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Game System
    /// </summary>
    public class GameSystem
    {
        /// <summary>
        /// Platform Id
        /// </summary>
        public string PlatformId { get; set; }

        /// <summary>
        /// Emulated?
        /// </summary>
        public bool Emulated { get; set; }

        /// <summary>
        /// Region Id
        /// </summary>
        public string RegionId { get; set; }

        internal GameSystem() { }
    }
}