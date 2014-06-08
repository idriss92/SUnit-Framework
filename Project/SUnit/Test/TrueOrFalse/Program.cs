using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUnit;
using SUnit.Framework;


namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testons les vrais et les faux");

            Assert.False(false);
            Assert.True(true);
        }
    }
}
