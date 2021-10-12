namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Color Info for how to display usernames on speedrun.com
    /// </summary>
    public class ColorInfo
    {
        /// <summary>
        /// Color hex code for light backgrounds (I think?)
        /// </summary>
        public string Light { get; set; }

        /// <summary>
        /// Color hex code for dark backgrounds (I think?)
        /// </summary>
        public string Dark { get; set; }

        internal ColorInfo() { }
    }
}