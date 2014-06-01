using System;
using System.Collections.Generic;


namespace SUnit//.src.SUnit.core
{
    /// <summary>
    /// Attribute used to provide description to a test case 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method| AttributeTargets.Class|AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public class DescriptionAttribute:Attribute
    {
        private string description;

        /// <summary>
        /// Construct the attribute
        /// </summary>
        /// <param name="description">Test describe the test </param>
        public DescriptionAttribute(string description)
        {
            this.description = description;
        }

        /// <summary>
        /// Get test description
        /// </summary>
        public string Description 
        {
            get { return description; }
        }

    }
}
