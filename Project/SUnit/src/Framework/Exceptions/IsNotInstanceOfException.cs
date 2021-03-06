﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    /// <summary>
    /// Throws when the object is unexpectedly not  the type of the exact given type
    /// </summary>
    public class IsNotInstanceOfException: Exception
    {
        /// <summary>
        /// Creates a instance of <see cref="InstanceNotTypeException"/>
        /// </summary>
        /// <param name="actual">The actual object reference</param>
        /// <param name="expected">The epected type</param>
        /// <param name="userMessage">The user message given</param>
        public IsNotInstanceOfException(object actual, Type expected, string userMessage)
            :base(userMessage ?? " " +actual +"must not be instance of "+expected)
        {

        }

        /// <summary>
        /// Creates a instance of <see cref="InstanceNotTypeException"/>
        /// </summary>
        /// <param name="actual">The actual object reference</param>
        /// <param name="expected">The expected type</param>
        public IsNotInstanceOfException(object actual , Type expected)
            :base( " " +actual +"must not be instance of "+expected)
        {

        }

    }
}
