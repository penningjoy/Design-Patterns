
/* Singleton Design Pattern
 * ---  Defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
   ---  Responsible for creating and maintaining its own unique instance.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlayground
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                car mynewcar = car.carspecs();
                Console.WriteLine(mynewcar.model + mynewcar.yearmake);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            // Both the two variables are essentially refering to same instance.
            try
            {
                car mydreamcar = car.carspecs();
                Console.WriteLine(mydreamcar.model + mydreamcar.yearmake);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
    sealed class car
    {
        private static car _instance = null;
        public string model = String.Empty;
        public string yearmake = String.Empty;
        private car() // Private constructor ==> Class cannot be instantiated anymore.
        {
            model = "Tesla";
            yearmake = "2019";
        }
        public static car carspecs()
        {
            _instance = new car(); // This is the only instance of the class that will be available.
            return _instance;
        }
    }
    */
}
