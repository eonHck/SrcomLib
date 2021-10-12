namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Country object for Locations
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Country code abbreviation
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        public string Name { get; set; }
    
        /// <summary>
        /// Country Name in Japanese
        /// </summary>
        public string JapaneseName { get; set; }

        internal Country() { }
    }
}