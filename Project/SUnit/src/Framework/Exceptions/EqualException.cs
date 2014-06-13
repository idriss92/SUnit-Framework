using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class EqualException:Exception
    {
        public EqualException(string userMessage)
            : base(userMessage ?? "Assert.Equal() Failure")
        {

        }
    }
}