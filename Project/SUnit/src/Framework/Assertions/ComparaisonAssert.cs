using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public partial class Assert 
    {
        /// <summary>
        /// Verifies that two objects referenced the same object
        /// </summary>
        /// <param name="actual">The actual object given</param>
        /// <param name="expected">The expected object given</param>
        /// <exception cref="AreSameException">Thrown when the test fail</exception>
        public static void AreSame(object actual, object expected)
        {
            AreSame(actual, expected, null);
        }

        /// <summary>
        /// Verfies that two objects referenced the same object
        /// </summary>
        /// <param name="actual">The actual object given</param>
        /// <param name="expected">The expected object given</param>
        /// <param name="userMessage">The User message given</param>
        /// <exception cref="AreSameException">Thrown when the test fail</exception>
        public static void AreSame(object actual, object expected, string userMessage)
        {
            if (!object.ReferenceEquals(actual, expected))
                throw new AreSameException(actual, expected,userMessage);
        }

        /// <summary>
        /// Verfies that two objects doesn't referenced the same object
        /// </summary>
        /// <param name="actual">The actual object given</param>
        /// <param name="expected">The expected object given</param>
        /// <exception cref="AreNotSameException">Thrown when the test fail</exception>
        public static void AreNotSame(object actual, object expected)
        {
            AreNotSame(actual, expected, null);
        }

        /// <summary>
        /// Verfies that two objects doesn't referenced the same object
        /// </summary>
        /// <param name="actual">The actual object given</param>
        /// <param name="expected">The expected object given</param>
        /// <param name="userMessage">The User message given</param>
        /// <exception cref="AreSameException">Thrown when the test fail</exception>
        public static void AreNotSame(object actual, object expected, string userMessage)
        {
            if (object.ReferenceEquals(actual, expected))
                throw new AreNotSameException(actual, expected, userMessage);
        }
    }
}
