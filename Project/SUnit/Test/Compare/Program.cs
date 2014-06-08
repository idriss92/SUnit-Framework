using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUnit.Framework;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 12;

            int c = 13;

            Assert.Equal(a, b);
            Assert.NotEqual(a, c,"A revoir");

        }
    }
}
