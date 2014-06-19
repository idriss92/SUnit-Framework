using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUnit.Framework;

namespace BooleanTest
{
    [TestFixture]
    public class BooleanTesting
    {
        [NUnit.Framework.Test]
        public void test_if_true_give_true()
        {
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.True(true));
        }

        [NUnit.Framework.Test]
        public void test_if_true_give_false()
        {
            NUnit.Framework.Assert.Throws<TrueException>(() => SUnit.Framework.Assert.True(false));
        }

        [NUnit.Framework.Test]
        public void test_if_false_give_false()
        {
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.False(false));
        }

        [NUnit.Framework.Test]
        public void test_if_false_give_true()
        {
            NUnit.Framework.Assert.Throws<FalseException>(() => SUnit.Framework.Assert.False(true));
        }

    }
}
