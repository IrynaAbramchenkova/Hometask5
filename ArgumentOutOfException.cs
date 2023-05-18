using System.Runtime.Serialization;

namespace Hometask5
{
    [Serializable]
    internal class ArgumentOutOfException : Exception
    {
        public ArgumentOutOfException()
        {
        }

        public ArgumentOutOfException(string? message) : base(message)
        {
        }

        public ArgumentOutOfException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ArgumentOutOfException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}