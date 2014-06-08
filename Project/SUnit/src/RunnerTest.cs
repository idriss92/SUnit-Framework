using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SUnit.Runner2
{
    public class RunnerTest
    {
        private int testFound = 0;
        private int testSucces = 0;
        private int testFail = 0;
        public Assembly DLL { get; set; }
        public List<MethodInfo> ListMethod { get; set; }
        public List<TypeInfo> ListClass { get; set; }


        /// <summary>
        /// Load the assembly 
        /// </summary>
        /// <param name="path"></param>
        public void LoadAssembly(String path)
        {
            try
            {
                 //Assembly assembly = Assembly.LoadFile(path);
                DLL = Assembly.LoadFile(path);
            }

            catch
            {
                throw new InvalidOperationException("Loading Dll failed");
            }
           
        }

        /// <summary>
        /// Store in a list the class which are in the assembly
        /// </summary>
        public void StoreClass()
        {
            ListClass = DLL.DefinedTypes.Where(c => c.CustomAttributes.Any(cl => cl.AttributeType.Name.Equals("TestClassAttribute"))).ToList();
        }

        /// <summary>
        /// Store in a list the method which are in the assembly
        /// </summary>
        public void StoreMethod()
        {
            //var meth = new List<MethodInfo>();
            //ListClass.ForEach(m => m.GetMethods().ToList().ForEach(me => meth.Add(me)));
            //ListMethod = meth.Where(m => m.CustomAttributes.Any(me => me.AttributeType.Name.Equals("TestAttribute"))).ToList();

        }


        /// <summary>
        /// Show the content of The collection of method
        /// </summary>
        public void Showmany()
        {
            if(ListMethod.Count != 0)
            {
                ListMethod.ForEach(c => Console.WriteLine("{0}", c));
            }
        }

        /// <summary>
        /// Instanciate the class and invoke each methods
        /// </summary>
        public void RunnerRunner()
        {
            object item;
            
            foreach(var cl in ListClass)
            {
                Console.WriteLine(cl.Name);
                item = Activator.CreateInstance(cl);
                
                foreach(var m in cl.GetMethods())
                {
                    Console.WriteLine(m);
                    //give acces to the metadata
                    ParameterInfo[] parameters = m.GetParameters();
                    m.Invoke(item,parameters);

                }
            }
        }
    }
}
