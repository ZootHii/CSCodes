using System;
using System.Collections.Generic;

namespace CSCollections
{
    internal static class ProgramCollections
    {
        public static void Main(string[] args)
        {
            // arraylists, lists, dictionaries, linkedlists are Collections.
            
            // different writings
            /*List<Test> tests = new List<Test>();
            tests.Add(new Test{Id = 1, Name = "Ahmet"});
            tests.Add(new Test{Id = 2, Name = "Ahmet2"});*/
            
            // different writings
            var tests = new List<Test>
            {
                new Test {Id = 1, Name = "Ahmet"}, 
                new Test {Id = 2, Name = "Ahmet2"}
            };

            foreach (var test in tests)
            {
                Console.WriteLine(test.ToString());
            }
            
            // dictionaries
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Computer", "Bilgisayar");
            dictionary.Add("Mouse", "Fare");
            dictionary.Add("Keyboard", "Klavye");
            //Console.WriteLine(dictionary["Computer"]);
            //Console.WriteLine(dictionary["eerer"]); // non exist so it throws error
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
    
    internal class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
}