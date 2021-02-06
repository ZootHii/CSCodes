using System.Collections.Generic;

namespace CS_OOP_3.Business
{
    public class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //TODO sum other works
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void MakeCreditPerNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}