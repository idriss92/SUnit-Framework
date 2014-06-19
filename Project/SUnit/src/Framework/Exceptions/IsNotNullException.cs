using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown when an object reference is unexpectedly null
    /// </summary>
    public class IsNotNullException : Exception
    {
        /// <summary>
        /// Create a new instance of the <see cref="IsNotNullException"/>
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="userMessage"></param>
        public IsNotNullException (object actual,string userMessage)
            :base(userMessage ?? " ")
        {

        }

        /// <summary>
        /// Create a new instance of the <see cref="IsNotNullException"/>
        /// </summary>
        /// <param name="actual"></param>
        public IsNotNullException(object actual)
            : base(" "+actual + " must not null ")
        {

        }
    }
}
