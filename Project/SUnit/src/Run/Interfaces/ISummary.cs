using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Run
{
    public interface ISummary
    {
        void TestMethod(MethodInfo m, object instance);
        bool TestPath(String path);
        bool TestFile(String path);

        void Total();

    }
}
