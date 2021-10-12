using System;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Image Assets for Users
    /// </summary>
    public class UserAssets
    {
        /// <summary>
        /// Icon image URI
        /// </summary>
        public Uri Icon { get; set; }

        /// <summary>
        /// Avatar image Uri
        /// </summary>
        public Uri Image { get; set; }

        internal UserAssets() { }
    }
}