using System.Collections.Generic;

namespace SrcomLib.ResponseObjects.SubObjects
{
    /// <summary>
    /// Variable Value for a particular Variable
    /// </summary>
    public class VariableValue
    {
        /// <summary>
        /// Id of the Variable Value
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Variable Id this Variable Value is associated with
        /// </summary>
        public string VariableId { get; set; }

        /// <summary>
        /// Name of this value
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Rules associated with this value
        /// </summary>
        public string Rules { get; set; }

        /// <summary>
        /// Is this a miscellaneous variable
        /// </summary>
        public bool IsMiscellaneous { get; set; }

        /// <summary>
        /// Variable Flags
        /// Should only contain a single entry for "miscellaneous"
        /// And the value should match the IsMiscellaneous property
        /// But this exists here in case new flags are ever added
        /// </summary>
        public Dictionary<string, bool?> Flags { get; set; }

        internal VariableValue() { }
    }
}