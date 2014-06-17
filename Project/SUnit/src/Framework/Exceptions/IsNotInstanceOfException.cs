using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class IsNotInstanceOfException: Exception
    {
        public IsNotInstanceOfException(object actual, Type expected, string userMessage)
            :base(userMessage ?? " " +actual +"must not be instance of "+expected)
        {

        }

        public IsNotInstanceOfException(object actual , Type expected)
            :base( " " +actual +"must not be instance of "+expected)
        {

        }

    }
}
