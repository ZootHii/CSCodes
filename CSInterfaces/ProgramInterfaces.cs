using System;

namespace CSInterfaces
{
    internal static class ProgramInterfaces
    {
        public static void Main(string[] args)
        {
            FirstPart();
            SecondPart();
            ThirdPart();
        }

        private static void ThirdPart()
        {
            /*ICustomerDal[] customerDals = {new SqlDal(), new OracleDal()}; //Upgrade with MySql in below
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }*/

            ICustomerDal[] customerDals = {new SqlDal(), new OracleDal(), new MySql()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void SecondPart()
        {
            CustomerManager customerManager = new CustomerManager();
            CustomerManager.Add(new OracleDal());
            CustomerManager.Add(new SqlDal());
        }

        private static void FirstPart()
        {
            PersonManager personManager = new PersonManager();
            PersonManager.Add(new Customer {Id = 1, FirstName = "Ahmet", LastName = "Y", Address = "Ankara"});
            PersonManager.Add(new Student {Id = 2, FirstName = "Ahmet2", LastName = "Y", Department = "CENG"});
        }
    }

    internal interface IPerson //abstract object can not be exist without concrete object
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class Customer : IPerson    //concrete object
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Address { get; set; }
    }

    internal class Student : IPerson    //concrete object
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Department { get; set; }
    }

    internal class PersonManager
    {
        public static void Add(IPerson person/*Customer customer*/) 
        {
            Console.WriteLine(person.FirstName + " added.");
            //Console.WriteLine(customer.FirstName + " added.");
        }
    }
}