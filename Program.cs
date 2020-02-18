/*  Developer -- Joydeep Banerjee, Date: 
 *  Compiled since November,2019
 *  ---------------------------------------------
 *  ------ DESIGN PATTERNS - GANG OF FOUR -------
 *  ---------------------------------------------
 * There are altogether 23 Gang of Four (GoF) design patterns. These design patterns are categorized in 3 groups: 
 * i.   Creational, 
 * ii.  Structural, and 
 * iii. Behavioral 
 */

using System;
namespace DesignPatternPlayground
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("1. Singleton - Creational Pattern \n" +
                              "2. Factory Method - Creational Pattern \n" +
                              "3. Prototype - Creational Pattern  \n" +
                              "4. Decorator - Structural Pattern \n" +
                              "5. Chain of Responsibility - Behavioural Pattern \n" +
                              "6. Strategy - Behavioural Pattern\n" +
                              "7. Observer - Behavioural Pattern \n" +
                              "8. Iterator - Behavioural Pattern"
                              );
            Console.Write("Please enter your choice : ");
            int choice = Int16.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            switch (choice)
            {
                case 1:
                    Singleton.MainCaller();
                    break;
                case 5:
                    ChainofResponsibility.MainCaller();
                    break;
                case 6:
                    StrategyPattern.MainCaller();
                    break;
                default:
                    Console.WriteLine("Sorry, we don't serve this yet.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
