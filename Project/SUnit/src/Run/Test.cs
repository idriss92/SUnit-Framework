using SUnit;
using SUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    public class Test : ITest, ISummary
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

        #region Unit Methods

        /// <summary>
        /// Load the assembly 
        /// </summary>
        /// <param name="path"></param>
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



        /// <summary>
        /// Test if the path specified is a directory
        /// </summary>
        /// <param name="path"></param>
        /// <returns>A boolean value</returns>
        public bool TestPath(String path)
        {
            var value = Directory.Exists(path);
            return value;
        }


        /// <summary>
        /// Test if the path specified is a file
        /// </summary>
        /// <param name="path"></param>
        /// <returns>A boolean value</returns>
        public bool TestFile(String path)
        {
            var value = File.Exists(path);
            return value;
        }



        /// <summary>
        /// Store in a list the class and Methods which are in the assembly
        /// </summary>
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

        /// <summary>
        /// Store in a list the method which are in the assembly
        /// </summary>
        public void StoreClassTest()
        {
            TestClassList = RealListClass.Where(c => c.CustomAttributes.Any(cl => cl.AttributeType.Name.Equals("TestClassAttribute"))).ToList();
        }


        /// <summary>
        /// Show the content of The collection of method
        /// </summary>
        public void Showmany()
        {
            if (ListMethod.Count != 0)
            {
                ListMethod.ForEach(c => Console.WriteLine("{0}", c));
            }
        }

        /// <summary>
        /// Instanciates the class and call the method which invoke our method test
        /// </summary>
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

        /// <summary>
        /// Get instance of class and name of method and invoke the method
        /// </summary>
        /// <param name="m"></param>
        /// <param name="instance"></param>
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


        /// <summary>
        /// Print a failed Method
        /// </summary>
        /// <param name="m"></param>
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


        public void RunTheCheck(string path)
        {
            LoadAssembly(path);
            Store();
            Console.WriteLine();
            StoreClassTest();
            TestRunner();
            Console.WriteLine();
            Total();
            Console.ReadLine();
        }
        #endregion

        //#region Recapitulate
        ///// <summary>
        ///// Dictionnary for Recapitulates who pass or not
        ///// </summary>
        //private Dictionary<MemberInfo, bool> ResultatFinal;

       
        ///// <summary>
        ///// Insert a couple key value of a method invoked and her statement
        ///// </summary>
        ///// <param name="name"></param>
        ///// <param name="passOrNot"></param>
        //private void AddCouple(MemberInfo name, bool passOrNot)
        //{
        //    Assert.IsNull(name);
        //    Assert.IsNull(passOrNot);
        //    ResultatFinal.Add(name, passOrNot);
        //}


        ///// <summary>
        ///// Getting the status of a method invoked
        ///// </summary>
        ///// <param name="name"></param>
        ///// <returns>The value of the statement</returns>
        //public bool GetValue(MemberInfo name)
        //{
        //    return ResultatFinal[name];
        //}

        //public MemberInfo GetKey(string value)
        //{
        //    return  ResultatFinal.First(k => k.Value.Equals(value)).Key;
        //}

        //public void PrintRecapitulate()
        //{
        //    //recupérer une liste des noms
        //    //var listenom = ListMethod.ForEach(m=>m.Name.);
        //    //var listeNom = ListMethod.ForEach(c => c.Name);
        //    foreach(var contenu in ListMethod)
        //    {
        //        Console.WriteLine(contenu.Name);

        //    }
        //}

        //#endregion
    }
}
