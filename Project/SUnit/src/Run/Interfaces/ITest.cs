using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Run
{
    public interface ITest
    {
        #region Unit Methods
        void LoadAssembly(String path);
        
        void Store();
        void StoreClassTest();
        void Showmany();
        void TestRunner();
       
        void Total();
        //void PrintListResult();

        #endregion
    }
}
