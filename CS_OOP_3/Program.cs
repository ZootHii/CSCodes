using System;
using System.Collections.Generic;
using CS_OOP_3.Business;

namespace CS_OOP_3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var dwellingCreditManager = new DwellingCreditManager();
            var vehicleCreditManager = new VehicleCreditManager();
            var consumerCreditManager = new ConsumerCreditManager();

            var applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(dwellingCreditManager, new List<ILoggerService>(){new DatabaseLoggerService(), new FileLoggerService()});

            Console.WriteLine("---------------------");

            var credits = new List<ICreditManager> {vehicleCreditManager, consumerCreditManager};
            applicationManager.MakeCreditPerNotification(credits);
        }
    }
}