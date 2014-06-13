using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class IsNullException : Exception
    {
        public IsNullException (string userMessage)
            :base(userMessage ?? "Assert.IsNull() Failure")
        {

        }
    }
}
