using System;

namespace CSInterfaces
{
    public interface ICustomerDal // Data Access Layer (DAL)
    {
        void Add();
        void Update();
        void Delete();
    }

    internal class SqlDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }
    }

    internal class OracleDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }
    }

    internal class MySql : ICustomerDal // added later SOLID PROGRAMMING
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }
    }

    internal class CustomerManager
    {
        public static void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}