using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown two objects references are unexpectedly the same instance
    /// </summary>
    public class AreNotSameException: Exception
    {
        /// <summary>
        /// Creates a new instance of the <see cref="AreNotSameException"/>
        /// </summary>
        /// <param name="actual">The actual object reference</param>
        /// <param name="expected">The expected object reference</param>
        public AreNotSameException(object actual, object expected)
            : base(actual + " and" + expected + " must not referenced the same object")
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AreNotSameException"/>
        /// </summary>
        /// <param name="actual">The actual object references</param>
        /// <param name="expected">The expected object references</param>
        /// <param name="userMessage">The user message given</param>
        public AreNotSameException(object actual, object expected,string userMessage)
            :base(userMessage?? actual+" and"+expected+ " must not referenced the same object")
        { 
        }
    }
}
