using System;

namespace Demo1
{
    public class CustomerManager
    {
        //public ILogger Logger { get; set; } // for true usage // it must be constructor but for now used this // property injection

        // Totally right usage with Constructor Injection
        private ILogger _logger;
        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }
        
        public void Add()
        {
            // wrong usage
            /*DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log();*/
            
            //Logger.Log(); // true usage // it must be constructor but for now used this
            _logger.Log(); // Totally right usage with Constructor Injection
            Console.WriteLine("Customer Added");
        }
    }
}