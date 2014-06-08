﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.src.SUnit.assert
{
    public partial class Assert
    {
        public static void AreSame(object expected, object actual)
        {
            if (!object.ReferenceEquals(expected, actual))
                throw new InvalidOperationException("Assert.AreSame() Failure");
        }
        public static void AreSame(object expected, object actual, string userMessage)
        {
            AreSame(expected, actual, userMessage);
        }


        public static void AreNotSame(object expected, object actual)
        {
            if (object.ReferenceEquals(expected, actual))
                throw new InvalidOperationException("Assert.ArenotSame() Failure");
        }
        public static void AreNotSame(object expected, object actual, string userMessage)
        {
            AreNotSame(expected, actual, userMessage);
        }
    }
}