namespace Demo1
{
    internal static class ProgramDemo1
    {
        public static void Main(string[] args)
        {
            // usage with properties
            /*CustomerManager customerManager = new CustomerManager();
            //customerManager.Logger = new DatabaseLogger(); // for true usage added this
            //customerManager.Logger = new FileLogger();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();*/

            // usage with Constructor Injection
            CustomerManager customerManager = new CustomerManager(new SmsLogger());
            customerManager.Add();
        }
    }
}