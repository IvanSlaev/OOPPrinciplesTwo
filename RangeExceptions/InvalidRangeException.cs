namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message, T start, T end) : base(message)
        {
            
        }
    }
}
