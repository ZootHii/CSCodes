using System;

namespace CSReferenceAndValueType
{
    internal static class ProgramReferenceAndValueType
    {
        public static void Main(string[] args)
        {
            // this is value type it is not refer the value's reference
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2); // it is gonna print 10
            
            // value type string in C#
            string text1 = "10";
            string text2 = "20";
            text2 = text1;
            text1 = "30";
            Console.WriteLine(text2); // it is gonna print 10
            
            // reference type //
            string[] cities1 = new string[3] {"Ankara", "Sivas", "Bursa"};
            string[] cities2 = new string[3] {"İstanbul", "İzmir", "Tokat"};
            cities2 = cities1; // we show cities1' s reference in cities2 in RAM so both look at the same reference like (101) 
            cities1[0] = "Ahmet"; // and the cities2 values have no usage anymore and garbage collector removes them
            Console.WriteLine(cities1[0] + cities2[0] + cities2[1]);
        }
    }
}