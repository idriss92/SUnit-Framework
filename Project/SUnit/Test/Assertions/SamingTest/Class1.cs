using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUnit.Framework;
namespace SamingTest
{

    public class ObjetTest
    {

    }

    [NUnit.Framework.TestFixture]
    public class SamingTest
    {
            
        [NUnit.Framework.Test]
        public void should_be_the_same_with_same_assert()
        {
            var a = new ObjetTest();
            var b = a;
            var c = a;

            NUnit.Framework.Assert.DoesNotThrow(()=>SUnit.Framework.Assert.AreSame(c,b));
        }

        [NUnit.Framework.Test]
        public void should_not_be_the_same_with_same_assert()
        {
            var a = new ObjetTest();
            var d = new ObsoleteAttribute();
            var c = a;
            var b = d;
            //var b = new ObsoleteAttribute ();
            NUnit.Framework.Assert.Throws<AreSameException>(()=>SUnit.Framework.Assert.AreSame(b,c));
        }

        [NUnit.Framework.Test]
        public void should_not_be_the_same_success_with_not_same_assert()
        {
            var a = new ObjetTest();
            var b = new ObsoleteAttribute();
            var c = a;
            var d = b;
            NUnit.Framework.Assert.DoesNotThrow(()=>SUnit.Framework.Assert.AreNotSame(c,d));
        }

        [NUnit.Framework.Test]
        public void should_not_be_the_same_failed_with_not_same_assert()
        {
            var a = new ObjetTest();
            var c = a;
            var d = a;
            NUnit.Framework.Assert.Throws<AreNotSameException>(()=>SUnit.Framework.Assert.AreNotSame(c,d));
        }

    }
}
