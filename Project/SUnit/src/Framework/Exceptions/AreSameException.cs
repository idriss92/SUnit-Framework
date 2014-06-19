using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown two objects references are not unexpectedly the same instance
    /// </summary>
    public class AreSameException : Exception
    {
        /// <summary>
        /// Creates a new instance of the <see cref="AreSameException"/>
        /// </summary>
        /// <param name="actual">The actual object reference</param>
        /// <param name="expected">The expected object reference</param>
        public AreSameException(object actual, object expected)
            : base(actual + " and" + expected + " must referenced the same object")
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AreSameException"/>
        /// </summary>
        /// <param name="actual">The actual object references</param>
        /// <param name="expected">The expected object references</param>
        /// <param name="userMessage">The user message given</param>
        public AreSameException(object actual, object expected,string userMessage)
            :base(userMessage?? actual+" and"+expected+ " must referenced the same object")
        { 
        }
    }
}
