using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit
{
    public class RunnerLoad
    {
        static void Main(string [] args)
        {
            Console.WriteLine("SUnit for S Library for C# Unit Test");

            var Run = new RunnerTest();

            //Load the librairy
            Run.LoadAssembly("C:\\Users\\SI\\Documents\\GitHub\\SUnit-Framework\\Project\\SUnit\\SUnit.Library.dll");
            Run.StoreClass();
            Run.StoreMethod();
            Run.Showmany();
            Run.RunnerRunner();
        }
    }
}
