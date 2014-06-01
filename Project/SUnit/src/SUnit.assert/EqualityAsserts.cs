using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.src.SUnit.assert
{
    public partial class Assert
    {
        #region Equal
        public static void Equal<T>(T actual, T expected, IEqualityComparer<T> compare)
        {
            if (!compare.Equals(actual, expected))
                throw new InvalidOperationException("Assert:AreEqual() Failure");
        }
        public static void Equal<T>(T actual, T expected)
        {
            Equal(actual, expected, null);
        }
        #endregion

        #region NotEqual
        public static void NotEqual<T>(T actual, T expected, IEqualityComparer<T> compare)
        {
            if (compare.Equals(actual, expected))
                throw new InvalidOperationException("Assert:AreNotEqual() Failure");
        }

        public static void NotEqual<T>(T actual, T expected)
        {
            NotEqual(actual, expected, null);
        }
        #endregion
    }
}
