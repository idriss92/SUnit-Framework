using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Exception thrown two values are unexpectedly equal
    /// </summary>

    public class NotEqualException:Exception
    {
        public string expected;
        public string actual;
        public string Actual { get; private set; }

        public string Expected { get; private set; }

        /// <summary>
        /// Creates a new instance of <see cref="NotEqualException"/>
        /// </summary>
        /// <param name="userMessage">The message given for show</param>
        public NotEqualException(string userMessage)
            :base(userMessage ?? " ")
        {

        }

        /// <summary>
        /// Creates a new instance of <see cref="NotEqualException"/>
        /// </summary>
        /// <param name="actual">The actual string value</param>
        /// <param name="expected">The expected string value</param>
        /// <param name="userMessage">The given user message</param>
        public NotEqualException(object actual, object expected, string userMessage)
            : base(userMessage + "Expected : "+ expected + " instead of "+actual)
        {
            Actual = Convert.ToString(actual);
            Expected = Convert.ToString(expected);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NotEqualException"/>
        /// </summary>
        /// <param name="actual">The actual string value</param>
        /// <param name="expected">The expected string value</param>
        public NotEqualException(object expected, object actual)
            : base("Expected  "+expected+ " instead of " + actual)
        {
            Actual = Convert.ToString(actual);
            Expected = Convert.ToString(expected);
        }
    }
}
