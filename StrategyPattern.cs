/* Behavioural Pattern - Strategy Pattern using Constructor Dependency Injection
 * Inversion of Control.
 */

using System;

namespace DesignPatternPlayground
{
    // This is dependency injection using constructor injection 
    public interface ibook
    {
        public string getname();
    }

    public class book : ibook
    {
        public string getname()
        {
            return "Harry Potter";
        }
    }

    public class Store
    {
        ibook _book;

        public Store(ibook book) // Constructor Dependency Injection
        {
            _book = book;
        }
        public Store()
        {
            _book = new book();
        }
        public string books()
        {
            return _book.getname();
        }
    }


    public class StrategyPattern
    {
        public static void MainCaller()
        {
            Store store = new Store();
            Console.WriteLine(store.books());
            Console.ReadLine();
        }

    }
}
