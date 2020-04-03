/* --------------------------------------------------------------------------------
 * Behavioural Pattern - Strategy Pattern (using Constructor Dependency Injection) 
 * --------------------------------------------------------------------------------
 * A class behaviour can be changed at runtime using the strategy pattern. Strategy Pattern uses a 
 *     1. Strategy Interface -- this define the action(s).
 *     2. Concrete strategy classes and -- these implement those action(s).
 *     3. Context class - This uses the above strategies.
 */

using System;

namespace DesignPatternPlayground
{
    //1. Strategy Interface
    public interface ibook
    {
        public string getname();
    }

    //2.1 Concrete Strategy Class
    public class Englishbook : ibook
    {
        public string getname()
        {
            return "Harry Potter";
        }
    }

    //2.2 Concrete Strategy Class
    public class Bengalibook : ibook
    {
        public string getname()
        {
            return "Sohoj Path";
        }
    }


    //3. Context Class
    public class Store
    {
        ibook _book;

        public Store(ibook book) // Constructor Dependency Injection
        {
            _book = book;
        }
        public string books()
        {
            return _book.getname();
        }
    }

    // Calls the context class
    public class StrategyPattern
    {
        public static void MainCaller()
        {
            Store store = new Store(new Englishbook());
            Console.WriteLine(store.books());

            store = new Store(new Bengalibook());
            Console.WriteLine(store.books());

            Console.ReadLine();
        }

    }
}
