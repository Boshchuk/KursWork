using System;

namespace ToyFactory.Business.Controllers.Implimentations
{
    public class ObjectUsedException : Exception
    {
        public ObjectUsedException(string message) : base(message)
        {

        }
    }
}