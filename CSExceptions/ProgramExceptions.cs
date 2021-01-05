using System;

namespace CSExceptions
{
    internal static class ProgramExceptions
    {
        public static void Main(string[] args)
        {
            // when we try to connect a database we must do exception handling
            // because it can show connection stuff that is important
            try
            {
                string[] students = new string[3]{"Ahmet", "Zoothii", "Yıldırım"};
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