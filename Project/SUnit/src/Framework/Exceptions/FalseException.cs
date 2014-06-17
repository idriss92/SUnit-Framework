using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class FalseException: Exception
    {
        public bool condition;
        public bool Condition { get; private set; }
        public FalseException(string userMessage)
            : base(userMessage ?? "")
        {

        }

        public FalseException(bool condition, string userMessage)
            :base("Expected "+ false + " instead of "+ true)
        {
            Condition = condition;
        }
    }
}
