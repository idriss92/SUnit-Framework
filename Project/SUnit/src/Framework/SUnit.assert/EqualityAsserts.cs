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



        public static void Equal(double actual, double expected, int exactitude)
        {
            Equal(actual, expected, null);
        }

        public static void Equal(double actual, double expected, int exactitude, string userMessage)
        {
            var actualValue = Math.Round(actual, exactitude);
            var expectedValue = Math.Round(expected, exactitude);
            if(!Equals(actualValue,expected))
                throw new InvalidOperationException(userMessage ?? "Assert.Equal() Failure");
        }

        //public static void Equal(Single actual, Single expected, Single exactitude)
        //{
        //    Equal(actual, expected, exactitude, null);
        //}

        //public static void Equal(Single actual, Single expected, Single exactitude, string userMessage)
        //{
        //    var actualValue = Math.Round(actual, exactitude);
        //    var expectedValue = Math.Round(expected, exactitude);
        //    if (!Equals(actualValue, expected))
        //        throw new InvalidOperationException(userMessage ?? "Assert.Equal() Failure");

        //    //Equal(actual, expected, null);
        //}

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
