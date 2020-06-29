using System;

namespace EduSync.Speech.Domain.Exceptions
{
    public class InvalidUrlAggregateException : AggregateException
    {
        public InvalidUrlAggregateException(string message) : base(message)
        {
        }
    }
}