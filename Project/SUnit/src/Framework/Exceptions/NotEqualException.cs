using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class NotEqualException:Exception
    {
        public string expected;
        public string actual;
        public string Actual { get; private set; }

        public string Expected { get; private set; }


        public NotEqualException(string userMessage)
            :base(userMessage ?? " ")
        {

        }

        public NotEqualException(object actual, object expected, string userMessage)
            : base(userMessage + "Expected : "+ expected + " instead of "+actual)
        {
            Actual = Convert.ToString(actual);
            Expected = Convert.ToString(expected);
        }

        public NotEqualException(object expected, object actual)
            : base("Expected  "+expected+ " instead of " + actual)
        {

        }
    }
}
