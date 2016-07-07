using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenCvSharp
{
    public class ApplicationException : Exception
    {
        public ApplicationException()
        {
        }

        public ApplicationException(string message) : base(message)
        {
        }

        public ApplicationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public interface ICloneable
    {
        object Clone();
    }

    public class Serializable : Attribute
    {

    }

    internal class AccessViolationException : Exception
    {

    }
}

namespace System.Security
{
    public sealed class SuppressUnmanagedCodeSecurityAttribute : Attribute
    {

    }
}