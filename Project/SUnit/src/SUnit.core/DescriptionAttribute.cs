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

        //constructeur
        public DescriptionAttribute(string description)
        {
            this.description = description;
        }

        //recupere la description du test
        public string DescriptionAttribute { get; }

    }
}
