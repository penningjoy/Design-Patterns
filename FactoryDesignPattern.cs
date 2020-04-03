/* --------------------------------------------------
 * Creational Pattern ---- Factory Design Pattern
 * --------------------------------------------------
 * Factory Design pattern provides a way to use an interface to 
 * create objects without exposing the concrete classes. Here a method is
 * created which returns an object to the caller.
 * 
 *  The key components to implementing this pattern : 
 *       i.  Product - an interface that defines the product characteristics
 *       ii. Concrete Product - a concrete class that implements the product interface.
 *       iii.Creator - an interface that declares the factories
 *       iv. Concrete Creator - concrete class that implements the creator interface and 
 *                              definies the factory method to create Product objects.
 *                           
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlayground
{
    //1. Product Interface
    public interface IDataStore
    {
        public string data { get; }
    }

    //2.1 Concrete Product Class
    public class DatabaseStorage : IDataStore
    {
        public string data
        {
            get
            {
                return "Data returned from Database.";
            }
        }
    }

    //2.2 Concrete Product Class
    public class CacheStorage : IDataStore
    {
        public string data
        {
            get
            {
                return "Data returned from Cache.";
            }
        }
    }
    /* Here it can be further abstracted by using an abstract class to define the 
       general structure of the factory classes. If more than one factory classes are 
       used, it is a good idea to use an abstract class and inherit that and overvide 
       the object creator methods. */

    public abstract class Datastorefactory
    {
        public abstract IDataStore GetStoreObject(string storetype);
    }
    // 3. Creator
    public class DataStoreObjectFactory : Datastorefactory
    {
        public override IDataStore GetStoreObject(string storetype)
        {
            switch (storetype)
            {
                case "database":
                    return new DatabaseStorage();

                case "cache":
                    return new CacheStorage();

                default:
                    throw new Exception("No such storage found");

            }

        }
    }
    // 4. Concrete Creator Class
    class FactoryDesignPattern
    {
        public static void MainCaller()
        {
            Datastorefactory datastorefactory = new DataStoreObjectFactory();
            Console.WriteLine("Let's fetch some data from storages.....");
            try
            {
                IDataStore databasecontent = datastorefactory.GetStoreObject("database");
                Console.WriteLine(databasecontent.data);

                IDataStore cachecontent = datastorefactory.GetStoreObject("cache");
                Console.WriteLine(cachecontent.data);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
