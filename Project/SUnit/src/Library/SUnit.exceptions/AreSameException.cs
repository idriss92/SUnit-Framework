using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.src.SUnit.exceptions
{
    public class AreSameException : Exception
    {
        public AreSameException (string userMessage)
            :base(userMessage ?? "Assert.AreSame() Failure")
        {

        }
    }
}
