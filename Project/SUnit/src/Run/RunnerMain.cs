using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    public class RunnerMain
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("SUnit for S Library for C# Unit Test");

            var run = new Test();
            run.RunTheCheck(args[0]);
        }
    }
}
