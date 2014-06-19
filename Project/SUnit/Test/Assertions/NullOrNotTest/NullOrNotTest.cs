using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUnit.Framework;

namespace NullOrNotTest
{

    [NUnit.Framework.TestFixture]
    public class NullOrNotTest
    {
        
        [NUnit.Framework.Test]
        public void Null_assert_should_pass()
        {
            int ? a = null;
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.IsNull(a));
        }

        [NUnit.Framework.Test]
        public void Null_assert_should_not_pass()
        {
            var a = 2;
            NUnit.Framework.Assert.Throws<IsNullException>(() => SUnit.Framework.Assert.IsNull(a));
        }



        [NUnit.Framework.Test]
        public void Not_null_assert_should_pass()
        {
            var a = 2;
            NUnit.Framework.Assert.DoesNotThrow(() => SUnit.Framework.Assert.IsNotNull(a));
        }

        [NUnit.Framework.Test]
        public void Not_null_assert_should_not_pass()
        {
            int? a = null;
            NUnit.Framework.Assert.Throws<IsNotNullException>(() => SUnit.Framework.Assert.IsNotNull(a));
        }


    }
}
