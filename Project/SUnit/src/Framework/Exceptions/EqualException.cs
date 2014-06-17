﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class EqualException:Exception
    {
        public string expected;
        public string actual;

        public string Actual { get; private set; }
        public string Expected { get; private set; }
        public EqualException(string userMessage)
            : base(userMessage ?? " ")
        {
           
        }

        public EqualException(object actual, object expected, string userMessage)
            :base(userMessage??" " +  " Expected : "+ expected + " instead of "+actual )
        {
            Actual = Convert.ToString(actual);
            Expected = Convert.ToString(expected);
        }

        public EqualException(object actual, object expected)
            : base("Expected  " + expected + " instead of " + actual)
        {

        }
    }
}