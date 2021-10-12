namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Location Object
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Country
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        public Region Region { get; set; }

        internal Location() { }
    }
}