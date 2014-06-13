using System;
using System.Collections.Generic;

namespace SUnit.Framework
{
    /// <summary>
    /// Attribute which encapsulate a method test
    /// </summary>

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class TestAttribute:Attribute
    {
        //private string description;

        public string Description { get; set; }
    }
}
