using System;
using System.Collections.Generic;
using System.Text;
/*
namespace DesignPatternPlayground
{
 
  // This is dependency injection using constructor injection 
  
    public class Store
    {
        ibook _book;

        public Store(ibook book)
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

    class ConstructorDependencyInjection
    {
       Store store = new Store();
       Console.WriteLine(store.books());
       Console.ReadLine();

    }
}
*/