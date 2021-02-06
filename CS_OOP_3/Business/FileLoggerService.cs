using System;

namespace CS_OOP_3.Business
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("File Logged.");
        }
    }
}