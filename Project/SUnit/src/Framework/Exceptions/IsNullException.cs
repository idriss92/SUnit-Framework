using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class IsNullException : Exception
    {
        public IsNullException (object actual,string userMessage)
            :base(userMessage ?? " ")
        {

        }

        public IsNullException(object actual)
            : base(" "+actual + " is not null ")
        {

        }
    }
}
