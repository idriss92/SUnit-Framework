using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class NotEqualException:Exception
    {
        public NotEqualException(string userMessage)
            :base(userMessage ?? "Assert.NotEqual() Failure")
        {

        }
    }
}
