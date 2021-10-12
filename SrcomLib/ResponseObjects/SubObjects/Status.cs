using System;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Run Status Object
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Run STatus
        /// </summary>
        public RunStatus RunStatus { get; set; }

        /// <summary>
        /// User Id of the moderator who examined the run
        /// Should be blank for Runs with a status of New
        /// </summary>
        public string Examiner { get; set; }

        /// <summary>
        /// When the run was verified
        /// Should be null for runs with a status of New
        /// </summary>
        public DateTime? VerifyDate { get; set; }

        internal Status() { }
    }
}