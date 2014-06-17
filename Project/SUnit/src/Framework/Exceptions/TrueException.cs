using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class TrueException:Exception
    {
        public bool condition;
        public bool Condition { get; private set; }
        public TrueException(string userMessage)
            :base(userMessage ?? " ")
        {

        }

        public TrueException(bool condition, string userMessage)
            :base("Expected "+ true + " instead of "+ false)
        {
            Condition = condition;
        }

    }
}
