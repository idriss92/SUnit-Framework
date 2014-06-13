using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUnit.Framework
{
    public class PrincipalException : Exception
    {
        //readonly string stack;
        /// <summary>
        /// Default constructor
        /// </summary>
        public PrincipalException ():base(){}

        /// <summary>
        /// Constructor which defines the property of the message
        /// </summary>
        /// <param name="message"></param>
        public PrincipalException (string userMessage):base(userMessage)
        {
            UserMessage= userMessage;
        }
        /// <summary>
        /// Constructor which defines the properties Message and InnerException 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public PrincipalException(string userMessage, Exception inner) : base(userMessage, inner) { }

        protected PrincipalException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }

        // <summary>
        // Gets the message
        // </summary>
        public string UserMessage { get; set; }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
