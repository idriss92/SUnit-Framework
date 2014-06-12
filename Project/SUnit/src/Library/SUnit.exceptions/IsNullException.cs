using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.src.SUnit.exceptions
{
    public class IsNullException : Exception
    {
        public IsNullException (string userMessage)
            :base(userMessage ?? "Assert.IsNull() Failure")
        {

        }
    }
}
