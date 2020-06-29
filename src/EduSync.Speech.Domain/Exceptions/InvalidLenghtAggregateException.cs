using System;

namespace EduSync.Speech.Domain.Exceptions
{
    public class InvalidLenghtAggregateException : AggregateException
    {
        public InvalidLenghtAggregateException(string message) : base(message)
        {
        }
    }
}