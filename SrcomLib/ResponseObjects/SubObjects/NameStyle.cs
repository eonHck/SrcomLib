namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Name Style to describe how names should display on the website
    /// </summary>
    public class NameStyle
    {
        /// <summary>
        /// Display Style
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Start color for a gradient
        /// (I think this should match ColorTo if it's not a gradient)
        /// </summary>
        public ColorInfo ColorFrom { get; set; }

        /// <summary>
        /// End color for a gradient
        /// (I think this should match ColorFrom if it's not a gradient)
        /// </summary>
        public ColorInfo ColorTo { get; set; }

        internal NameStyle() { }
    }
}