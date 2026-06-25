using System;

namespace Services.Implementation.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        // This is the default constructor (0 arguments)
        public ResourceNotFoundException() : base() { }

        // THIS is the constructor your code is looking for (1 argument)
        public ResourceNotFoundException(string message) : base(message) { }

        // This handles inner exceptions (2 arguments)
        public ResourceNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}