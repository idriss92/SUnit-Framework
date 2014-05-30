using System;
using System.Collections;



namespace SUnit//.src.SUnit.core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=true,Inherited = true)]
    public class TestClassAttribute : Attribute
    {
        /// <summary>
        /// Attribute which encapsulate a class test
        /// </summary>

        private object[] arguments;
        private string description;


        public TestClassAttribute(params object[] arguments)
        {
            for (int i = 0; i < this.arguments.Length; i++)
            {
            }
        }


        //Description
        public string Description {get;set;}
        //public Description{get;set;}

    }
}
