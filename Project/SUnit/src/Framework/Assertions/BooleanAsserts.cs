using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public partial class Assert
    {
        #region True

        /// <summary>
        /// verifies that an condition is <code>true</code>
        /// </summary>
        /// <param name="condition">The given condtion</param>
        /// <exception cref="TrueException">Thrown if the condition is <code>false</code></exception>
        public static void True(bool condition)
        {
            True(condition, null);
        }

        /// <summary>
        /// Verifies that a condition is <code>true</code>
        /// </summary>
        /// <param name="condition">The given condition</param>
        /// <param name="userMessage">The given user message</param>
        /// <exception cref="TrueException">Thrown if the condition is <code>false</code></exception>
        public static void True(bool condition, string userMessage)
        {
            if (!condition)
                throw new TrueException(userMessage);
        }
        #endregion

        #region False
        /// <summary>
        /// Verifies that a condition is <code>false</code>
        /// </summary>
        /// <param name="condition">The given condition</param>
        /// <exception cref="FalseException">Thrown if the condition is <code>true</code></exception>
        public static void False(bool condition)
        {
            False(condition, null);
        }

        /// <summary>
        /// Verifies that a condition is <code>false</code>
        /// </summary>
        /// <param name="condition">The given condition</param>
        /// <param name="userMessage">The given user message</param>
        /// <exception cref="FalseException">Thrown if the condition is <code>true</code></exception>
        public static void False(bool condition, string userMessage)
        {
            if (condition)
                throw new FalseException(userMessage);
        }
        #endregion
    }
}
