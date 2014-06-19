using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUnit.Framework;

namespace EqualityTest
{
    [NUnit.Framework.TestFixture]
    public class EqualityTest
    {
        [NUnit.Framework.Test]
        public void should_pass_with_same_type_value_Equal()
        {
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.Equal(2, 2));
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.Equal(2.3, 2.3));
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.Equal(2/2, 2/2));
        }

        [NUnit.Framework.Test]
        public void should_not_pass_with_same_type_value_Equal()
        {
            NUnit.Framework.Assert.Throws<EqualException>(() => SUnit.Framework.Assert.Equal(2, 0.2));
            NUnit.Framework.Assert.Throws<EqualException>(() => SUnit.Framework.Assert.Equal(2.3, 3.3));
            NUnit.Framework.Assert.Throws<EqualException>(() => SUnit.Framework.Assert.Equal(2 / 2, 5 / 2));
        }

        [NUnit.Framework.Test]
        public void should_pass_with_same_type_value_NotEqual()
        {
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.Equal(2, 2));
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.Equal(2.3, 2.3));
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.Equal(2 / 2, 2 / 2));
        }

        [NUnit.Framework.Test]
        public void should_not_pass_with_same_type_value_NotEqual()
        {
            NUnit.Framework.Assert.Throws<EqualException>(() => SUnit.Framework.Assert.Equal(2, 0.2));
            NUnit.Framework.Assert.Throws<EqualException>(() => SUnit.Framework.Assert.Equal(2.3, 3.3));
            NUnit.Framework.Assert.Throws<EqualException>(() => SUnit.Framework.Assert.Equal(2 / 2, 5 / 2));
        }

    }
}
