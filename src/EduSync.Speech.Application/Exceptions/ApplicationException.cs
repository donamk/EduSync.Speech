using System;

namespace EduSync.Speech.Application.Exceptions
{
    public class ApplicationException : Exception
    {
        internal ApplicationException(string messsage) : base(messsage)
        {
        }
    }
}