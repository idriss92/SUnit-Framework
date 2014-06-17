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
        public static void IsNull(object objet)
        {
            IsNull(objet, null);
        }
        public static void IsNull(object objet, string userMessage)
        {
            if (objet != null)
                throw new IsNullException(userMessage ?? "Assert.IsNull() Failure");

        }
        #endregion

        #region IsNotNull
        public static void IsNotNull( object objet)
        {
            IsNotNull(objet, null);            
        }
        public static void IsNotNull(object objet, string userMessage) 
        {
            if (objet == null)
                throw new IsNotNullException(userMessage ?? "Assert.IsNotNull() Failure");
        }
        #endregion
    }
}
