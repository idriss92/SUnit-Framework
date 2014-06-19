using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public partial class Assert 
    {
        #region IsInstanceOfType

        /// <summary>
        /// Verifies that an object is an instance of a given type
        /// </summary>
        /// <param name="objet">The objectgiven object</param>
        /// <param name="monType">The expected given</param>
        /// <exception cref="IsInstanceOfException">Thrown when the test fail</exception>
        public static void IsInstanceOfType(object objet, Type monType)
        {
            IsInstanceOfType(objet, monType, null);
        }


        /// <summary>
        /// Verifies that an object is an instance of a given type
        /// </summary>
        /// <param name="objet">The objectgiven object</param>
        /// <param name="type">The expected given</param>
        /// <param name="userMessage">The User Message given</param>
        /// <exception cref="IsInstanceOfException">Thrown when the test fail</exception>
        public static void IsInstanceOfType(object objet, Type type, string userMessage)
        {
            if (!(objet.GetType().Equals(type)))
                throw new IsInstanceOfException(objet,type,userMessage);
        }
        #endregion


        #region IsNotInstanceOfType
        /// <summary>
        /// Verifies that an object is an instance of a given type
        /// </summary>
        /// <param name="objet">The objectgiven object</param>
        /// <param name="type">The expected given</param>
        /// <param name="userMessage">The User Message given</param>
        /// <exception cref="IsInstanceOfException">Thrown when the test fail</exception>

        public static void IsNotInstanceOfType(object objet, Type type, string userMessage)
        {
            if ((objet.GetType().Equals(type)))
                throw new IsNotInstanceOfException(objet, type, userMessage); 
        }

        /// <summary>
        /// Verifies that an object is not an instance of a given type
        /// </summary>
        /// <param name="objet">The objectgiven object</param>
        /// <param name="monType">The expected given</param>
        /// <exception cref="IsNotInstanceOfException">Thrown when the test fail</exception>

        public static void IsNotInstanceOfType(object objet, Type monType)
        {
            IsNotInstanceOfType(objet,monType,null);
        }
        #endregion
    }
}
