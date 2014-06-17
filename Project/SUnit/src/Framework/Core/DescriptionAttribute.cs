using System;
using System.Collections.Generic;


namespace SUnit.Framework
{
    /// <summary>
    /// Attribute used to provide description to a test class or a test method 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method| AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class DescriptionAttribute:Attribute
    {
        private string Description { get; set; }

        /// <summary>
        /// Construct the attribute
        /// </summary>
        /// <param name="description">Test description </param>
        public DescriptionAttribute(string description)
        {
            Description = description;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DescriptionAttribute()
        {

        }
    }
}
