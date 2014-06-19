using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public partial class Assert
    {
        #region IsNull

        /// <summary>
        /// Verifies that the object is null
        /// </summary>
        /// <param name="objet">The object to be tested</param>
        /// <exception cref="IsNullException">Thrown if the object is null</exception>
        public static void IsNull(object objet)
        {
            IsNull(objet, null);
        }
        /// <summary>
        /// Verifies that the object is null
        /// </summary>
        /// <param name="objet">The object to be tested</param>
        /// <param name="userMessage">The message given when Exception is thrown</param>
        /// <exception cref="IsNullException">Thrown if the object is null</exception>
        public static void IsNull(object objet, string userMessage)
        {
            if (objet != null)
                throw new IsNullException(objet);

        }
        #endregion

        #region IsNotNull
        /// <summary>
        /// Verifies that the object is null
        /// </summary>
        /// <param name="objet">The object to be tested</param>
        /// <exception cref="IsNotNullException">Thrown if the object is null</exception>
        public static void IsNotNull( object objet)
        {
            IsNotNull(objet, null);            
        }
        /// <summary>
        /// Verifies that the object is null
        /// </summary>
        /// <param name="objet">The object to be tested</param>
        /// <param name="userMessage">The message given when Exception is thrown</param>
        /// <exception cref="IsNotNullException">Thrown if the object is null</exception>

        public static void IsNotNull(object objet, string userMessage) 
        {
            if (objet == null)
                throw new IsNotNullException(objet);
        }
        #endregion
    }
}
