using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Throws when the object is unexpectedly not  the type of the exact given type
    /// </summary>
    public class IsInstanceOfException : Exception
    {
        /// <summary>
        /// Creates a instance of <see cref="InstanceTypeException"/>
        /// </summary>
        /// <param name="actual">The actual object reference</param>
        /// <param name="expected">The expected type</param>
        /// <param name="userMessage">The user message given</param>
        public IsInstanceOfException(object actual, Type expected, string userMessage)
            :base(userMessage ?? " " +actual +"must not be instance of "+expected)
        {

        }

        /// <summary>
        /// Creates a instance of <see cref="InstanceTypeException"/>
        /// </summary>
        /// <param name="actual">The actual object reference</param>
        /// <param name="expected">The expected message given</param>
        public IsInstanceOfException(object actual, Type expected)
            :base(" " +actual+ " Must be instance of "+expected)
        {

        }
    }
}
