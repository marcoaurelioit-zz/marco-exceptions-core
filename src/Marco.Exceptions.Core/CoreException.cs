using System;
using System.Runtime.Serialization;

namespace Marco.Exceptions.Core
{
    [Serializable]
    public abstract class CoreException : Exception
    {
        public abstract string Key { get; }
        public abstract override string Message { get; }

        protected CoreException() : base()
        {
        }
        protected CoreException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}