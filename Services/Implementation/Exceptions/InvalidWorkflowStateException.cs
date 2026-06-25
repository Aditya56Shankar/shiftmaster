using System;

namespace Services.Implementation.Exceptions
{
    public class InvalidWorkflowStateException : Exception
    {
        public InvalidWorkflowStateException() : base() { }

        public InvalidWorkflowStateException(string message) : base(message) { }

        public InvalidWorkflowStateException(string message, Exception innerException) : base(message, innerException) { }
    }
}