using System;

namespace CS_OOP_3.Business
{
    public class ConsumerCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated for ConsumerCredit");
        }
    }
}