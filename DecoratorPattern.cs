/* --------------------------------------------------
 * Structural Pattern ---- Decorator Design Pattern
 * --------------------------------------------------
 * Decorator design pattern offers a way to incorporate additional 
 * functionalities to an object dynamically. It is done by subclassing.
 * 
 * There are few keys components to implementing this pattern : 
 *            i. Component -  an interface that defines the default features.
 *            ii. Concrete Component - concrete class(es) that implements the component interface.
 *            iii. Decorator Interface/ Abstract Class -- an interface or an abstract class that conforms
 *                                                        to the Component interface.
 *                                                        
 *            iv. Concrete Decorator -- a concrete class that adds the additional feature.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlayground
{
    // User Definition ---- >Glorified Structure 
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    // 1. Component
    interface IUser
    {
        public User getUserDetails();
    }

    //2.1 Concrete Component
    class InternalUser : IUser
    {
        public User getUserDetails()
        {
            User internalUser1 = new User( );
            internalUser1.FirstName = "Pushpita" ;
            internalUser1.LastName = "Choudhury";
            return internalUser1;
        }
    }

    //2.2 Concrete Component
    class ExternalUser : IUser
    {
        public User getUserDetails()
        {
            User externalUser1 = new User();
            externalUser1.FirstName = "Joydeep";
            externalUser1.LastName = "Banerjee";
            return externalUser1;
        }
    }

    //3. Decorate Interface
    abstract class AdditionalUserProp : IUser
    {
       private IUser _user;
       public AdditionalUserProp(IUser user)
       {
            _user = user;
       }
        public User getUserDetails()
        {
            return _user.getUserDetails();
        }
    }
    //4. Concrete Decorator
    class UserInfoWithAddress : AdditionalUserProp
    {
       private IUser _user;
       public UserInfoWithAddress(IUser user) : base(user) 
       {
            _user = user;
       }
       public string getAddress()
       {
            return "Philadelphia";
       }
    }
    
    class DecoratorPattern
    {
        public static void MainCaller()
        {
            UserInfoWithAddress userIntinfo = new UserInfoWithAddress(new InternalUser());
            UserInfoWithAddress userExtinfo = new UserInfoWithAddress(new ExternalUser());

            Console.WriteLine(userIntinfo.getUserDetails().FirstName + " " + userIntinfo.getUserDetails().LastName + " Address : " + userIntinfo.getAddress());
            Console.WriteLine(userExtinfo.getUserDetails().FirstName + " " + userExtinfo.getUserDetails().LastName + " Address : " + userExtinfo.getAddress());
        }

    }
}
