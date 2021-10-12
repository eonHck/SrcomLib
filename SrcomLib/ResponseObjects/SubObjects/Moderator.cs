namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Moderator object
    /// </summary>
    public class Moderator
    {
        /// <summary>
        /// The Moderator's User Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Moderator Type
        /// </summary>
        public ModeratorType ModeratorType { get; set; }

        internal Moderator() { }
    }
}