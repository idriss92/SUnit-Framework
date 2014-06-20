using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    public class RunnerMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUnit for S Library for C# Unit Test");

            var Run = new Test();

            //Load the librairy
            //Run.LoadAssembly(@"C:\Users\SI\Documents\GitHub\SUnit-Framework\Project\SUnit\SUnit.Samples.dll");
            
            //Assembly to load in the string[] args
            Run.LoadAssembly(args[0]);
            Run.Store();
            Console.WriteLine();
            Run.StoreClassTest();

            Console.WriteLine();
            Run.TestRunner();
            Console.WriteLine();
            Run.Total();
            Console.WriteLine();
            //Run.PrintListResult();
            Console.ReadLine();
        }
    }
}
