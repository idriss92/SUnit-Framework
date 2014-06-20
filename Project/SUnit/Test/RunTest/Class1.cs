using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Run;
using System.Reflection;
using System.IO;

namespace RunTest
{

    public class Run
    {
        #region Declaration Members
        public int TestFound { get; set; }
        public int TestSucces { get; set; }
        private int TestFail { get; set; }
        public Assembly DLL { get; set; }
        public List<MethodInfo> ListMethod { get; set; }
 
        public List<Type> RealListClass { get; set; }
        public List<Type> TestClassList { get; set; }
        #endregion
        public void LoadAssembly(String path)
        {
            try
            {
                DLL = Assembly.LoadFrom(path);
                //DLL = Assembly.LoadFile(path);
            }

            catch
            {
                throw new InvalidOperationException("Loading Dll failed");
            }

        }




        public bool TestPath(String path)
        {
            var value = Directory.Exists(path);
            return value;
        }


        public bool TestFile(String path)
        {
            var value = File.Exists(path);
            return value;
        }




        public void Store()
        {
            
            var ListClass = DLL.GetTypes().ToList();

            RealListClass = ListClass.Where(c => c.CustomAttributes.Any(cl => cl.AttributeType.Name.Equals("TestClassAttribute"))).ToList();
            var meth = new List<MethodInfo>();

            foreach (var item in RealListClass)
            {
                var recu = item.GetMethods().ToList();
                recu.ForEach(m => meth.Add(m));
            }
            ListMethod = meth.Where(m => m.CustomAttributes.Any(me => me.AttributeType.Name.Equals("TestAttribute"))).ToList();
        }


        public void StoreClassTest()
        {
            TestClassList = RealListClass.Where(c => c.CustomAttributes.Any(cl => cl.AttributeType.Name.Equals("TestClassAttribute"))).ToList();
        }


        public void Showmany()
        {
            if (ListMethod.Count != 0)
            {
                ListMethod.ForEach(c => Console.WriteLine("{0}", c));
            }
        }

        public void TestRunner()
        {
            object item;
            
            TestFound = ListMethod.Count;
            
            foreach (var cl in TestClassList)
            {
                //Console.WriteLine(cl.Name);
                item = Activator.CreateInstance(cl);
                foreach (var m in cl.GetMethods().Where(m => m.CustomAttributes.Any(me => me.AttributeType.Name.Equals("TestAttribute"))).ToList())
                {
                    //Console.WriteLine(m);
                    TestMethod(m, item);
                }
            }
        }

        public void TestMethod(MethodInfo m , object instance)
        {
            //give acces to the metadata
            ParameterInfo[] parameters = m.GetParameters();
            try
            {
                m.Invoke(instance,parameters);
                TestSucces += 1;
            }
            catch(TargetInvocationException e)
            {
                StringBuilder messageerror = new StringBuilder();
                messageerror.Append(m.ReflectedType.FullName);
                messageerror.Append(m.Name+"()");
                messageerror.Append(". ");
                messageerror.Append(e.GetBaseException().TargetSite.Name+" verification failed ");
                messageerror.Append(". ");
                messageerror.Append(e.InnerException.Message);
                
                Console.WriteLine(messageerror);
                Console.WriteLine();
                TestFail += 1;         
            }
        }



        public void PrintFailedAMethod(MethodInfo m)
        {
            Console.WriteLine(m.ReflectedType.FullName + "." + m.Name+"()");
        }


        /// <summary>
        /// Print the summary of all the test
        /// </summary>
        public void Total()
        {
            if(TestSucces.Equals(TestFound))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }

            Console.WriteLine("Tests found {0}, {1} success, {2} failed", TestFound,TestSucces,TestFail);
        }
    }

    [TestFixture]
    public class RunTest
    {
        
        [Test]
        public void Should_Load_Assembly()
        {
            var a = new Run();
            Assert.DoesNotThrow(()=>a.LoadAssembly(@"C:\Users\SI\Documents\GitHub\SUnit-Framework\Project\SUnit\Samples\SUnit.Samples.dll"));
        }

        [Test]
        public void Should_test_path()
        {
            var a = new Run();
            Assert.DoesNotThrow(() => a.TestPath(@"C:\Users\SI\Documents\GitHub"));
        }

        [Test]
        public  void Should_test_file()
        {
            var a = new Run();
            Assert.DoesNotThrow(() => a.TestFile(@"C:\Users\SI\Documents\GitHub\SUnit-Framework\Project\SUnit\SUnit.Samples.dll"));
        }
    }
}
