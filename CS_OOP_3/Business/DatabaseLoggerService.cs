using System;

namespace CS_OOP_3.Business
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Database Logged.");
        }
    }
}