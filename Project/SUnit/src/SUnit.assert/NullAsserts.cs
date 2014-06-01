using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.src.SUnit.assert
{
    public partial class Assert
    {
        #region IsNull
        public static void IsNull(object objet)
        {
            if (objet != null)
                throw new InvalidOperationException("Assert.IsNull() Failure");

        }
        public static void IsNull();
        #endregion

        #region IsNotNull
        public static void IsNotNull( object objet)
        {
            if (objet == null)
                throw new InvalidOperationException("Assert.IsNotNull() Failure");
        }
        public static void IsNotNull();
        #endregion
    }
}
