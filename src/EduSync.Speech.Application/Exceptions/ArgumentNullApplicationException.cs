namespace EduSync.Speech.Application.Exceptions
{
    public class ArgumentNullApplicationException : ApplicationException
    {
        internal ArgumentNullApplicationException(string message) : base(message)
        {
        }
    }
}