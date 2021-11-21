using System;

namespace Lesson30
{
    class DivideByFiveException : Exception
    {
        public DivideByFiveException(string message) : base(message + "tried divide by 5!") { }
    }
}
