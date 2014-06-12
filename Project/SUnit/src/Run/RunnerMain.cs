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
           // Run.LoadAssembly("C:\\Users\\SI\\Documents\\GitHub\\SUnit-Framework222\\Project\\SUnit\\SUnit.Samples.dll");
            
            //Assembly to load in the string[] args
            Run.LoadAssembly(args[0]);
            Run.Store();
            Run.StoreClassTest();
            Run.Showmany();
            Run.RunnerRunner();
            Run.Total();

            Console.ReadLine();
        }
    }
}
