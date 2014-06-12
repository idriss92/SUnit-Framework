using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SUnit;
using SUnit.Framework;

namespace Run
{
    public class Test
    {
        #region Declaration Members
        public int TestFound { get; set; }

        public int TestSucces { get; set; }
        private int TestFail { get; set; }
        public Assembly DLL { get; set; }
        public List<MethodInfo> ListMethod { get; set; }
        //public List<Type> ListClass { get; set; }
        private List<Type> ListClass;
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
                //Assembly assembly = Assembly.LoadFile(path);
                DLL = Assembly.LoadFrom(path);
            }

            catch
            {
                throw new InvalidOperationException("Loading Dll failed");
            }

        }

        /// <summary>
        /// Store in a list the class and Methods which are in the assembly
        /// </summary>
        public void Store()
        {
            
            ListClass = DLL.GetTypes().ToList();
            
            var meth = new List<MethodInfo>();

            foreach (var item in ListClass)
            {
                meth = item.GetMethods().ToList();
            }
            ListMethod = meth.Where(m => m.CustomAttributes.Any(me => me.AttributeType.Name.Equals("TestAttribute"))).ToList();
        }

        /// <summary>
        /// Store in a list the method which are in the assembly
        /// </summary>
        public void StoreClassTest()
        {
            TestClassList = ListClass.Where(c => c.CustomAttributes.Any(cl => cl.AttributeType.Name.Equals("TestClassAttribute"))).ToList();
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
        public void RunnerRunner()
        {
            object item;
            foreach (var i in ListMethod)
            {
                Console.WriteLine(i.Name," ",i.GetType());
            }
            TestFound = ListMethod.Count;
            //var filtre = ListClass.Where(c => c.CustomAttributes.Any(cl => cl.AttributeType.Name.Equals("TestClassAttribute")));
            int z = 0;
            foreach (var cl in TestClassList)
            {
                Console.WriteLine(cl.Name);
                item = Activator.CreateInstance(cl);

                foreach (var m in cl.GetMethods())
                {
                    Console.WriteLine(m);
                    TestMeth(m, item);
                }
            }
        }

        /// <summary>
        /// Get instance of class and name of method and invoke the method
        /// </summary>
        /// <param name="m"></param>
        /// <param name="instance"></param>
        private void TestMeth(MethodInfo m , object instance)
        {
            //give acces to the metadata
            ParameterInfo[] parameters = m.GetParameters();
            try
            {
                m.Invoke(instance,parameters);
                TestSucces += 1;
               // Console.WriteLine(m.Name);
                //ResultatFinal.Add(m, true);
            }
            catch(TargetInvocationException e)
            {
                StringBuilder messageerror = new StringBuilder();
                messageerror.Append("[FAil]");
                messageerror.Append(m.DeclaringType);
                messageerror.Append(m.Name);
                messageerror.Append(e.GetBaseException().TargetSite.Name);
                messageerror.Append(e.InnerException.Message);
                Console.WriteLine(e.Message.ToString());
                TestFail += 1;
                //ResultatFinal.Add(m, false);
            }
        }

        public void Total()
        {
            if(TestSucces.Equals(TestFound))
            {
                Console.ForegroundColor.Equals(ConsoleColor.Green);
            }
            else
            {
                Console.ForegroundColor.Equals(ConsoleColor.Red);
            }

            Console.WriteLine("Tests found {0}, {1} success, {2} failed", TestFound,TestSucces,TestFail);
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
