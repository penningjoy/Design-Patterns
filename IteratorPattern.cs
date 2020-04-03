/* --------------------------------------------------
 * Behavioural Pattern ---- Iterator Design Pattern
 * --------------------------------------------------
 * Iterator design pattern gives a way to access elements of a Collection in a sequential manner. It does not
 * have to know the underlying working for the iteration to work.
 * 
 * There are few keys components to implementing this pattern : 
 *            i.  Client --  Class that contains a collection object and calls the next() method to access the collection items.
 *            ii. IteratorInterface -- Interface that defines the operations to ACCESS the collection items.
 *            iii.ConcreteIterator -- Concrete class that implements the operations to ACCESS the collection items.
 *            ív. AggregatorInterface -- Interface that defines the operations to CREATE the collection.
 *             v. ConcreteAggregator -- Concrete class that implements the operations to CREATE the collection.
 * 
*/ 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlayground
{
    // 4. Aggregator Interface
    public interface IShoppingListAggregator
    {
        IShoppingListIterator createIterator();
        public int count { get; }
        public void add(object itemobject);
    }
    // 2. Iterator Interface
    public interface IShoppingListIterator
    {
        object currentItem { get; }
        bool next();
    }

    // 5. Aggregator Concrete Class 

    public class ShoppingListAggregator:IShoppingListAggregator
    {
        private List<object> _items = new List<object>();
        public IShoppingListIterator createIterator()
        {
            return new ShoppingListIterator(this);
        }
        public object this [int index]
        {
            get { return _items[index]; }
        }
        public int count
        {
            get { return _items.Count; }
        }
        public void add(object itemobject)
        {
            _items.Add(itemobject);
        }
    }

    //3... Interator Concrete Class

    public class ShoppingListIterator : IShoppingListIterator
    {
        private ShoppingListAggregator _aggregator;
        private int index;

        public ShoppingListIterator(ShoppingListAggregator aggregator)
        {
            _aggregator = aggregator;
            index = -1;
        }

        public bool next()
        {
            index++;
            return (index < _aggregator.count);
        }

        public object currentItem
        {
            get
            {
                if (index < _aggregator.count)
                    return _aggregator[index];
                else
                    throw new InvalidOperationException();
            }
        }            
    }
       
    // 1.. Client 
    class IteratorPattern
    {
        public static void MainCaller()
        {
            int i = 0;
            IShoppingListAggregator shoppingList = new ShoppingListAggregator();
            shoppingList.add("Tomatoes");
            shoppingList.add("Onions");
            shoppingList.add("Potatoes");
            shoppingList.add("Milk");
            shoppingList.add("Bread");

            IShoppingListIterator items = shoppingList.createIterator();
            Console.WriteLine("Shopping List : ");

            while (items.next())
            {
                string item = (string)items.currentItem;
                Console.WriteLine($"item {++i} : {item}" );
            }
            Console.ReadLine();
        }
    }
}
