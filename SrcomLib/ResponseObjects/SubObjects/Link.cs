using System;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Link Object
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Describes the link target
        /// </summary>
        public string Rel { get; set; }
        
        /// <summary>
        /// Link Target URI
        /// </summary>
        public Uri Uri { get; set; }

        internal Link() { }
    }
}