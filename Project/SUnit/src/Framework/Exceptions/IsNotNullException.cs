using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class IsNotNullException : Exception
    {
        public IsNotNullException (object actual,string userMessage)
            :base(userMessage ?? " ")
        {

        }

        public IsNotNullException(object actual)
            : base(" "+actual + " is not null ")
        {

        }
    }
}
