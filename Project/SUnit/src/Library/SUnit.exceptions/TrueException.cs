using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.src.SUnit.exceptions
{
    public class TrueException:Exception
    {
        public TrueException(string userMessage)
            :base(userMessage ?? "Assert.True() Failure")
        {

        }
    }
}
