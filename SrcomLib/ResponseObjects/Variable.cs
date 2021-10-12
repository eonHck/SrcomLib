using SrcomLib.ResponseObjects.SubObjects;
using System.Collections.Generic;

namespace SrcomLib.ResponseObjects
{
    /// <summary>
    /// Variable Object
    /// </summary>
    public class Variable
    {
        /// <summary>
        /// Variable Id on speedrun.com
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Variable Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category Id associated with the variable, null for variables that apply to all categories
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// Scope of the variable
        /// </summary>
        public ScopeType ScopeType { get; set; }

        /// <summary>
        /// Is the variable required on run submissions
        /// </summary>
        public bool Mandatory { get; set; }

        /// <summary>
        /// Is the variable user defined
        /// </summary>
        public bool UserDefined { get; set; }

        /// <summary>
        /// Does the variable obselete runs with other values for this variable
        /// </summary>
        public bool Obsoletes { get; set; }

        /// <summary>
        /// List of Values for this variable
        /// </summary>
        public IReadOnlyList<VariableValue> Values { get; set; }

        /// <summary>
        /// Is this a sub-category variable
        /// </summary>
        public bool IsSubCategory { get; set; }

        /// <summary>
        /// Links for data related to the Variable to access via the api
        /// </summary>
        public IReadOnlyList<Link> Links { get; set; }

        internal Variable() { }
    }
}