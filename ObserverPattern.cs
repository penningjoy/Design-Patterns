/* --------------------------------------------------
 * Behavioural Pattern ---- Observer Design Pattern
 * --------------------------------------------------
 *  i.  ---  Observer pattern is much like the Hollywood Principle : 'Don't call us, we will you.' 
 *           Pub - Sub ( Publisher - Subscribe )  another moniker for Observer Pattern
    ii. ---  Suppose there are a number of OBSERVERS who are interested in a special object called SUBJECT.
             This subject is called PUBLISHER. OBSERVERS subscribe to PUBLISHER such that whenever the 
             PUBLISHER publishes or raises an event, the SUBSCRIBERS are notified.
    iii. --- In the following example -- there is an Book Store which has a huge and a continuously updating 
                                         inventory. The store wants to update its users/customers whenever there is 
                                         a new book available. 
                                         Here the book store is going to be the SUBJECT or PUBLISHER. The OBSERVERS
                                         (customers/users) who have subscribed to store notifications would be notified 
 *                                       through email.
 *
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlayground
{

    /** Observers  : Users / Customers **/
    public interface IObserver
    {
        void update();
    }

    class Observer : IObserver
    {
        public string ObserverName { get; private set; }
        public Observer(string name)
        {
            this.ObserverName = name;
        }

        public void update()
        {
            Console.WriteLine($"{this.ObserverName} : new books have arrived. Please check out our new collection!");
        }
    }

    /** Publisher  : Book Store **/
    public interface IPublisher
    {
        void subscribe(IObserver observer);
        void unsubscribe(IObserver observer);
        void notify();
        void booksLibrary(int NumberofBookstoAdd);
    }

    public class Publisher : IPublisher
    {
        public  List<IObserver> _customers = new List<IObserver>();
        private int numberofbooks = 0;
        public void subscribe( IObserver observer)
        {
            _customers?.Add(observer);
        }
        public void unsubscribe(IObserver observer)
        {
            _customers?.Remove(observer);
        }
        public void notify()
        {
            if (_customers.Count == 0)
            {
                throw new Exception("No customer has subscribed yet..!");
            }
            _customers?.ForEach(o => o.update());   
        }

        public void booksLibrary(int NumberofBookstoAdd)
        {
            if(NumberofBookstoAdd > 0)
            {
                numberofbooks += NumberofBookstoAdd;
                notify();
            }
            
        }
    }
    public class ObserverPattern
    {
        public static void MainCaller()
        {
            IPublisher bestBookStore = new Publisher();
            IObserver customer1 = new Observer("Joydeep Banerjee");
            IObserver customer2 = new Observer("Pushpita Choudhury");
            /*
            bestBookStore.subscribe(customer1);
            bestBookStore.subscribe(customer2); */
            try
            {
                bestBookStore.booksLibrary(4);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }

}
