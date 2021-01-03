using System;

namespace CSConstructors
{
    internal static class ProgramConstructors
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.List();
            
            // first
            Console.WriteLine();
            Product product = new Product(1,"pc");
            // second
            Product product2 = new Product {Id = 1, Name = "TV"};
            
            //important
            Console.WriteLine();
            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();
            EmployeeManager employeeManager2 = new EmployeeManager(new DatabaseLogger());
            employeeManager2.Add();
            
            // part 3
            Console.WriteLine();
            PersonManager personManager = new PersonManager("Ahmet");
            personManager.Add();
            
        }
    }
    
    // part 1 start
    internal class CustomerManager
    {
        private int _count = 15; // start private fields with "_", this is standard

        public CustomerManager(int count)
        {
            _count = count;
        }

        // overloaded, different signature
        public CustomerManager()
        {
            
        }

        public void List()
        {
            Console.WriteLine("Listed items: " + _count);
            //Console.WriteLine("Listed items: {0}", _count);
        }
    }

    internal class Product
    {
        // First usage
        private int _id;
        private string _name;
        
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public Product() {}

        // Second usage
        public int Id { get; set; }
        public string Name { get; set; }
    }
    // part 1 end
    
    // part 2 start
    internal interface ILogger
    {
        void Log();
    }
    
    internal class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }
    
    internal class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    internal class EmployeeManager // right usage of logger thing inside the demo using Constructor Injection
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    // part 2 end
    
    // part 3 start
    internal class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    internal class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
    
}