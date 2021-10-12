using SrcomLib.ResponseObjects.SubObjects;
using System;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// User Object
    /// </summary>
    public class User
    {
        /// <summary>
        /// Used to differentiate between Users and Guests when embedded in a Run object, null otherwise
        /// </summary>
        public string Rel { get; set; }

        /// <summary>
        /// User Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User Name in Japanese
        /// </summary>
        public string JapaneseName { get; set; }

        /// <summary>
        /// User pronouns
        /// </summary>
        public string Pronouns { get; set; }

        /// <summary>
        /// URI for accessing the User via a web browser
        /// </summary>
        public Uri Weblink { get; set; }

        /// <summary>
        /// Display styles for the User Name in the website
        /// </summary>
        public NameStyle NameStyle { get; set; }

        /// <summary>
        /// User Role
        /// </summary>
        public UserRole Role { get; set; }

        /// <summary>
        /// Date the user signed up
        /// </summary>
        public DateTime Signup { get; set; }

        /// <summary>
        /// User's Location
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// User's Twitch URI
        /// </summary>
        public Uri Twitch { get; set; }

        /// <summary>
        /// User's HitBox URI
        /// </summary>
        public Uri HitBox { get; set; }

        /// <summary>
        /// User's YouTube URI
        /// </summary>
        public Uri YouTube { get; set; }

        /// <summary>
        /// User's Twitter URI
        /// </summary>
        public Uri Twitter { get; set; }

        /// <summary>
        /// User's SpeedRunsLive Uri
        /// </summary>
        public Uri SpeedRunsLive { get; set; }

        /// <summary>
        /// User Assets
        /// </summary>
        public UserAssets Assets { get; set; }

        /// <summary>
        /// Links for data related to the Series to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal User() { }
    }
}