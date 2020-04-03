/* --------------------------------------------------------
 * Creational Design Pattern ---- Prototype Pattern
 * --------------------------------------------------------
 * Prototype is a creational design pattern that allows cloning objects, even complex ones,
 * without coupling to their specific classes.
 * 
 * Cases where object creation can be expensive. It is best to clone an existing 
 * object rather than creating another one using the costlier path.
 * Example -- If an object is created everytime after a long database operation, it will be
 * highly expensive to do the database operation only to create another object. It is then 
 * advisable to clone the existing object and keep it in a cache only to be used when required.
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlayground
{
    class Student
    {
        public string name { get; set; }
        public int rollnum { get; set; }

        public Student getStudent()
        {
            return (Student)(this.MemberwiseClone());
        }
    }
    class PrototypePattern
    {
        public static void MainCaller()
        {
            Student firstgirl = new Student();
            firstgirl.name = "Pushpita Choudhury";
            firstgirl.rollnum = 1;

            Student secondboy = firstgirl.getStudent();

            Console.WriteLine($"{firstgirl.name} , Roll Number : {firstgirl.rollnum}");
            Console.WriteLine($"{secondboy.name} , Roll Number : {secondboy.rollnum}");

            secondboy.name = "Joydeep Banerjee";
            secondboy.rollnum = 2;

            Console.WriteLine($"{firstgirl.name} , Roll Number : {firstgirl.rollnum}");
            Console.WriteLine($"{secondboy.name} , Roll Number : {secondboy.rollnum}");
            Console.WriteLine($"{firstgirl.name} , Roll Number : {firstgirl.rollnum}");

        }
    }
}

/* -- Output -- 
 *  Pushpita Choudhury , Roll Number : 1
    Pushpita Choudhury , Roll Number : 1
    Pushpita Choudhury , Roll Number : 1
    Joydeep Banerjee , Roll Number : 2
    Pushpita Choudhury , Roll Number : 1



    *--- The class student can be re-written using the IClonable interface ----
    * 
    * class Student : IClonable
     {
       public string name { get; set; }
        public int rollnum { get; set; }

        public Student Clone()   // This method has to be used 
        {
            return this.MemberwiseClone();
        }
    }
    
*/

