namespace Exceptions
{
    class UserException : Exception
    {
        public UserException(string message)
            : base(message) { }
    }
}