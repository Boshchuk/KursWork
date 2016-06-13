using System;

namespace ToyFactory.Dal
{
    public class CantConnectToDbException : Exception
    {
        /// <summary>
        /// Simple custom exception
        /// </summary>
        /// <param name="message"></param>
        public CantConnectToDbException(string message) : base(message)
        {
        }
    }
}