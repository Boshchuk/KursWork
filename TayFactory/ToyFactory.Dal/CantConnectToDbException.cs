using System;

namespace ToyFactory.Business
{
    public class CantConnectToDbException : Exception
    {
        public CantConnectToDbException(string message) : base(message)
        {
        }
    }
}