using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class IsNotNullException : Exception
    {
        public IsNotNullException(string userMessage)
            :base(userMessage ?? "Assert.IsNotNull() Failure")
        {

        }
    }
}
