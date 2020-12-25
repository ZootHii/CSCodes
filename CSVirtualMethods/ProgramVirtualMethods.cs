/*
 
* AHMET 'ZootHii' YILDIRIM

*/

using System;
// works only for inheritance not interfaces
namespace CSVirtualMethods
{
    internal static class ProgramVirtualMethods
    {
        public static void Main(string[] args)
        {
            Sql sql = new Sql();
            Oracle oracle = new Oracle();
            Database database = new Database();
            sql.Add();
            oracle.Add();
            database.Add();
        }
    }

    internal class Database
    {
        public virtual void Add() // if virtual is added we can override the method
        {
            Console.WriteLine("Added by default");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    internal class Sql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL");
            //base.Add();
        }

        /*public void Delete() // if it is not added we can not override
        {
            
        }*/
    }

    internal class Oracle : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Oracle");
        }
    }
}