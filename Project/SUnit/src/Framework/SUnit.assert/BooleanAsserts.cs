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
        public static void True(bool condition)
        {
            True(condition, null);
        }

        public static void True(bool condition, string userMessage)
        {
            if (!condition)
                throw new InvalidOperationException(userMessage ?? "Assert.True() Failure");
        }
        #endregion

        #region False
        public static void False(bool condition)
        {
            False(condition, null);
        }

        public static void False(bool condition, string userMessage)
        {
            if (condition)
                throw new InvalidOperationException(userMessage ?? "Assert.False() Failure");
        }
        #endregion
    }
}

