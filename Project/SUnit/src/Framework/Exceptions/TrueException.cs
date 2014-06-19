using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown when a condition is unexpectedly not true
    /// </summary>
    public class TrueException:Exception
    {
        public bool condition;
        public bool Condition { get; private set; }

        /// <summary>
        /// Creates a new instance of <see cref="TrueException"/>
        /// </summary>
        /// <param name="userMessage"></param>
        public TrueException(string userMessage)
            :base(userMessage??"Expected True instead of False")
        {
        }

    }
}
