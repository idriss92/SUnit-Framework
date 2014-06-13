using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class FalseException: Exception
    {
        public FalseException(string userMessage)
            : base(userMessage ?? "Assert.False() Failure")
        {

        }
    }
}
