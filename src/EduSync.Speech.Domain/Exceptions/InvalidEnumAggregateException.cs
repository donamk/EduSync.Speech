using System;

namespace EduSync.Speech.Domain.Exceptions
{
    public class InvalidEnumAggregateException : AggregateException
    {
        public InvalidEnumAggregateException(string message) : base(message)
        {
        }
    }
}