using System;
using System.Collections;



namespace SUnit.Framework
{
    /// <summary>
    /// Attribute which encapsulate a class test
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=true,Inherited = true)]
    public class TestClassAttribute : Attribute
    {

    }
}
