using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown two values are not unexpectedly equal
    /// </summary>
    public class EqualException:Exception
    {
        public string expected;
        public string actual;

        public string Actual { get; private set; }
        public string Expected { get; private set; }

        /// <summary>
        /// Creates a new instance of <see cref="EqualException"/>
        /// </summary>
        /// <param name="userMessage">The message given for show</param>
        public EqualException(string userMessage)
            : base(userMessage ?? " ")
        {
           
        }

        /// <summary>
        /// Creates a new instance of <see cref="EqualException"/>
        /// </summary>
        /// <param name="actual">The actual string value</param>
        /// <param name="expected">The expected string value</param>
        /// <param name="userMessage">The given user message</param>

        public EqualException(object actual, object expected, string userMessage)
            :base(userMessage??" " +  " Expected : "+ expected + " instead of "+actual )
        {
            Actual = Convert.ToString(actual);
            Expected = Convert.ToString(expected);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EqualException"/>
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        public EqualException(object actual, object expected)
            : base("Expected  " + expected + " instead of " + actual)
        {
            Actual = Convert.ToString(actual);
            Expected = Convert.ToString(expected);
        }
    }
}