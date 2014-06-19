using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUnit.Framework;
using NUnit.Framework;

namespace InstanceTest
{
    public class MonElem1
    { }
    public class MonElem2
    { }
    
    [NUnit.Framework.TestFixture]
    public class InstanceTest
    {
        [NUnit.Framework.Test]
        public void should_be_instance_succes()
        {
            var a = new MonElem1();
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.IsInstanceOfType(a,typeof(MonElem1)));
        }

        [NUnit.Framework.Test]
        public void should_be_instance_failed()
        {
            var a = new MonElem2();
            NUnit.Framework.Assert.Throws<IsInstanceOfException>(() => SUnit.Framework.Assert.IsInstanceOfType(a, typeof(MonElem1)));
        }

        [NUnit.Framework.Test]
        public void should_not_be_instance_succes()
        {
            var a = new MonElem2();
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.IsNotInstanceOfType(a, typeof(MonElem1)));
        }

        [NUnit.Framework.Test]
        public void should_not_be_instance_failed()
        {
            var a = new MonElem2();
            NUnit.Framework.Assert.Throws<IsNotInstanceOfException>(() => SUnit.Framework.Assert.IsNotInstanceOfType(a, typeof(MonElem2))); 
        }

    }
}
