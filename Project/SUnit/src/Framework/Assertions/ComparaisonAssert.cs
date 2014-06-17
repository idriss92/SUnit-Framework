using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public partial class Assert 
    {
        public static void AreSame(object expected, object actual)
        {
            if (!object.ReferenceEquals(expected, actual))
                throw new AreSameException ("Assert.AreSame() Failure");
        }
        public static void AreSame(object expected, object actual, string userMessage)
        {
            AreSame(expected, actual, userMessage);
        }


        public static void AreNotSame(object expected, object actual)
        {
            if (object.ReferenceEquals(expected, actual))
                throw new AreNotSameException("Assert.ArenotSame() Failure");
        }
        public static void AreNotSame(object expected, object actual, string userMessage)
        {
            AreNotSame(expected, actual, userMessage);
        }
    }
}
