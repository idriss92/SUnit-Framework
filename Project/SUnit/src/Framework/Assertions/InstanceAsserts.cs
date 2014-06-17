﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public partial class Assert 
    {
        #region IsInstanceOfType
        public static void IsInstanceOfType(object objet, Type monType)
        {
            IsInstanceOfType(objet, monType, null);
        }
        public static void IsInstanceOfType(object objet, Type type, string userMessage)
        {
            if (!(objet.GetType().Equals(type)))
                throw new InvalidOperationException(userMessage ?? " Assert.IsInstanceOfType() Failure");
        }
        #endregion


        #region IsNotInstanceOfType
        public static void IsNotInstanceOfType(object objet, Type type, string userMessage)
        {
            if ((objet.GetType().Equals(type)))
                throw new InvalidOperationException(userMessage ?? "Assert.IsInstanceOfType() Failure"); 
        }

        public static void IsNotInstanceOfType(object objet, Type monType)
        {
            IsNotInstanceOfType(objet,monType,null);
        }
        #endregion
    }
}