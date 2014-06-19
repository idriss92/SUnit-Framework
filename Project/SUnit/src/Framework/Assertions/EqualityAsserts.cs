using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public partial class Assert 
    {
        #region Equal

        /// <summary>
        /// Verifies that two values are equal
        /// </summary>
        /// <typeparam name="T">The type of the given variables</typeparam>
        /// <param name="actual">The actual value given</param>
        /// <param name="expected">The expected value given</param>
        /// <exception cref="EqualException">Thrown if the values are not equal</exception>
        public static void Equal<T>(T actual, T expected)
        {
            Equal(actual, expected, null);
        }

        /// <summary>
        /// Verifies that two values are equal
        /// </summary>
        /// <typeparam name="T">The type of the given variables</typeparam>
        /// <param name="actual">The actual value given</param>
        /// <param name="expected">The expected value given</param>
        /// <param name="userMessage">The given user message</param>
        /// <exception cref="EqualException">Thrown if the values are not equal</exception>
        public static void Equal<T>(T actual, T expected, string userMessage)
        {
            if (!actual.Equals(expected))
                throw new EqualException(actual, expected, userMessage);
        }

        #endregion

        #region NotEqual

        /// <summary>
        /// Verifies that two values are not equal
        /// </summary>
        /// <typeparam name="T">The type of the given variables</typeparam>
        /// <param name="actual">The actual value given</param>
        /// <param name="expected">The expected value given</param>
        /// <exception cref="EqualException">Thrown if the values are not equal</exception>
        public static void NotEqual<T>(T actual, T expected)
        {
            NotEqual(actual, expected, null);
        }

        /// <summary>
        /// Verifies that two values are not equal
        /// </summary>
        /// <typeparam name="T">The type of the given variables</typeparam>
        /// <param name="actual">The actual value given</param>
        /// <param name="expected">The expected value given</param>
        /// <param name="userMessage">The given user message</param>
        /// <exception cref="NotEqualException">Thrown if the values are equal</exception>
        public static void NotEqual<T>(T actual, T expected, string userMessage)
        {
            if (actual.Equals(expected))
                throw new NotEqualException(actual,expected,userMessage);
        }

        #endregion
    }
}
