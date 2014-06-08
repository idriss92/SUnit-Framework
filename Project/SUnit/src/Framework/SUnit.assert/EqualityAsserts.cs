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


        public static void Equal<T>(T actual, T expected)
        {
            Equal(actual, expected, null);
        }

        public static void Equal<T>(T actual, T expected, string userMessage)
        {
            if (!actual.Equals(expected))
                throw new InvalidOperationException(userMessage ?? "Assert.Equal() Failure");
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

        public static void Equal(decimal actual, decimal expected, int exactitude)
        {
            Equal(actual, expected, null);
        }

        public static void Equal(decimal actual, decimal expected, int exactitude, string userMessage)
        {
            var actualValue = Math.Round(actual, exactitude);
            var expectedValue = Math.Round(expected, exactitude);
            if (!Equals(actualValue, expected))
                throw new InvalidOperationException(userMessage ?? "Assert.Equal() Failure");
        }

        public static void Equal(float actual, float expected, int exactitude)
        {
            Equal(actual, expected, null);
        }

        public static void Equal(float actual, float expected, int exactitude, string userMessage)
        {
            var actualValue = Math.Round(actual, exactitude);
            var expectedValue = Math.Round(expected, exactitude);
            if (!Equals(actualValue, expected))
                throw new InvalidOperationException(userMessage ?? "Assert.Equal() Failure");
        }

        #endregion

        #region NotEqual
        public static void NotEqual<T>(T actual, T expected)
        {
            NotEqual(actual, expected, null);
        }

        public static void NotEqual<T>(T actual, T expected, string userMessage)
        {
            if (actual.Equals(expected))
                throw new InvalidOperationException(userMessage ?? "Assert.Equal() Failure");
        }
        public static void NotEqual(double actual, double expected, int exactitude)
        {
            NotEqual(actual, expected, null);
        }

        public static void NotEqual(double actual, double expected, int exactitude, string userMessage)
        {
            var actualValue = Math.Round(actual, exactitude);
            var expectedValue = Math.Round(expected, exactitude);
            if (Equals(actualValue, expected))
                throw new InvalidOperationException(userMessage ?? "Assert.NotEqual() Failure");
        }

        public static void NotEqual(decimal actual, decimal expected, int exactitude)
        {
            NotEqual(actual, expected, null);
        }

        public static void NotEqual(decimal actual, decimal expected, int exactitude, string userMessage)
        {
            var actualValue = Math.Round(actual, exactitude);
            var expectedValue = Math.Round(expected, exactitude);
            if (Equals(actualValue, expected))
                throw new InvalidOperationException(userMessage ?? "Assert.NotEqual() Failure");
        }

        public static void NotEqual(float actual, float expected, int exactitude)
        {
            Equal(actual, expected, null);
        }

        public static void NotEqual(float actual, float expected, int exactitude, string userMessage)
        {
            var actualValue = Math.Round(actual, exactitude);
            var expectedValue = Math.Round(expected, exactitude);
            if (Equals(actualValue, expected))
                throw new InvalidOperationException(userMessage ?? "Assert.NotEqual() Failure");
        }


        #endregion
    }
}
