﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class AreSameException : Exception
    {
        public AreSameException (string userMessage)
            :base(userMessage ?? " ")
        {

        }
    }
}
