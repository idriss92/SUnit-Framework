using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class AreNotSameException: Exception
    {
        public AreNotSameException(string userMessage)
            :base(userMessage ?? " ")
        { 
        }
    }
}
