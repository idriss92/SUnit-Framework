using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.src.SUnit.exceptions
{
    public class IsNotNullException : Exception
    {
        public IsNotNullException(string userMessage)
            :base(userMessage ?? "Assert.IsNotNull() Failure")
        {

        }
    }
}
