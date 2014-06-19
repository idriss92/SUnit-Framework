using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown when a condition is unexpectedly not false
    /// </summary>
    public class FalseException: Exception
    {
        public bool condition;
        public bool Condition { get; private set; }

        /// <summary>
        /// Creates a new instance of <see cref="FalseException"/>
        /// </summary>
        /// <param name="userMessage"></param>
        public FalseException(string userMessage)
            :base(userMessage ?? "Expected False instead of True")
        {
            Condition = condition;
        }
    }
}
