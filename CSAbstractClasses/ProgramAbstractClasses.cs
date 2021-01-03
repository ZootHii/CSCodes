/*
 
* AHMET 'ZootHii' YILDIRIM

*/

using System;

namespace CSAbstractClasses
{
    internal static class ProgramAbstractClasses
    {
        public static void Main(string[] args)
        {
            // Abstract classes cannot be instantiated but they can be subclassed like interfaces
            //Database database = new Database();
            
            Database database = new Oracle();
            database.Add();
            database.Delete();
            
            
            Database database2 = new SQLServer();
            database2.Add();
            database2.Delete();
        }
    }

    public abstract class Database
    {
        public void Add() // completed method
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); // not completed method, needed to be overwrite, kind of empty virtual method
    }

    public class SQLServer : Database
    {
        public override void Delete() // in here overwrote
        {
            Console.WriteLine("Deleted by sqlserver");
        }
    }

    public class Oracle : Database
    {
        public override void Delete() // in here overwrote
        {
            Console.WriteLine("Deleted by oracle");
        }
    }
}