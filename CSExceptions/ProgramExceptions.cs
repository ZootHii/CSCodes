using System;
using System.Collections.Generic;

namespace CSExceptions
{
    internal static class ProgramExceptions
    {
        public static void Main(string[] args)
        {
            //First();
            
            /*try
            {
                Second();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }*/
            
            // sending to a method a method (gönderilen parametrenin türü method ise) ACTION DELEGATE
            // makes code clean readable if we have a lot catch blocks
            /*HandleException(() =>
            {
                Second();
            });*/
            
            // the same thing more clear
            HandleException(Second);
        }
        
        // we put everything in here like a normal method
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Second()
        {
            List<string> list = new List<string> {"Ahmet", "Zotthii", "Yıldırım"};

            if (!list.Contains("Burak"))
            {
                throw new RecordNotFoundException(message: "Record Not Found."); // Important
                //throw new RecordNotFoundException("Record Not Found"); // It can work like in top one (message)
                
            }
            else
            {
                Console.WriteLine("Record Found.");
            }
        }

        private static void First()
        {
            // when we try to connect a database we must do exception handling
            // because it can show connection stuff that is important
            try
            {
                string[] students = new string[3] {"Ahmet", "Zoothii", "Yıldırım"};
                students[3] = "Ahmet2"; // throws an error
            }
            catch (Exception exception)
            {
                Console.WriteLine("EXCEPTION!");
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.Source);
            }
        }
    }
}