using System;

namespace CSExceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message) // Important
        {
        }
    }
}