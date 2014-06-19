using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown when an object reference is unexpectedly not null
    /// </summary>
    public class IsNullException : Exception
    {
        /// <summary>
        /// Create a new instance of the <see cref="IsNullException"/>
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="userMessage"></param>
        public IsNullException (object actual,string userMessage)
            :base(userMessage ?? " ")
        {

        }

        /// <summary>
        /// Creates a new instance of the <see cref="IsNullException"/>
        /// </summary>
        /// <param name="actual"></param>
        public IsNullException(object actual)
            : base(" "+actual + " must be null ")
        {

        }
    }
}
