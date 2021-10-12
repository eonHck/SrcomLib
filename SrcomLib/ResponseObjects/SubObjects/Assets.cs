using System;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Image Asset Links
    /// </summary>
    public class Assets
    {
        /// <summary>
        /// URI for the Logo image
        /// </summary>
        public Uri Logo { get; set; }

        /// <summary>
        /// URI for the CoverTiny image
        /// </summary>
        public Uri CoverTiny { get; set; }

        /// <summary>
        /// URI for the CoverSmall image
        /// </summary>
        public Uri CoverSmall { get; set; }

        /// <summary>
        /// URI for the CoverMedium image
        /// </summary>
        public Uri CoverMedium { get; set; }

        /// <summary>
        /// URI for the CoverLarge image
        /// </summary>
        public Uri CoverLarge { get; set; }

        /// <summary>
        /// URI for the Icon image
        /// </summary>
        public Uri Icon { get; set; }

        /// <summary>
        /// URI for the Trophy1st image
        /// </summary>
        public Uri Trophy1st { get; set; }

        /// <summary>
        /// URI for the Trophy2nd image
        /// </summary>
        public Uri Trophy2nd { get; set; }

        /// <summary>
        /// URI for the Trophy3rd image
        /// </summary>
        public Uri Trophy3rd { get; set; }

        /// <summary>
        /// URI for the Trophy4th image
        /// </summary>
        public Uri Trophy4th { get; set; }

        /// <summary>
        /// URI for the Background image
        /// </summary>
        public Uri Background { get; set; }

        /// <summary>
        /// URI for the Foreground image
        /// </summary>
        public Uri Foreground { get; set; }

        internal Assets() { }
    }
}