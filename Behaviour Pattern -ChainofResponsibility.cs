
/* Chain of Responsibility 
 * Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
 * Chain the receiving objects and pass the request along the chain until an object handles it.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPlayground
{
    /*
    interface IArithmaticOperation
    {
        public void setNext(IArithmaticOperation nextInChain);
        public void Operation(Request request);
    }

    class Request
    {
        private int _num1, _num2;

        public Request(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public int getNumberOne()
        {
            return _num1;
        }
        public int getNumberTwo()
        {
            return _num2;
        }
        
    }

    class AdditionOperation : IArithmaticOperation
    {
        private static Request _request;
        private static IArithmaticOperation _nextinchain;
        public void setNext(IArithmaticOperation nextInChain)
        {
            _nextinchain = nextInChain;
        }

        public void Operation(Request request)
        {
            _request = request;
            Console.WriteLine($"The sum of {request.getNumberOne()} and {request.getNumberTwo()}  is : {request.getNumberOne() + request.getNumberTwo()}");
            _nextinchain?.Operation(_request);
        }
    }

    class SubtractionOperation : IArithmaticOperation
    {
        private static Request _request;
        private static IArithmaticOperation _nextinchain;
        public void setNext(IArithmaticOperation nextInChain)
        {
            _nextinchain = nextInChain;
        }

        public void Operation(Request request)
        {
            _request = request;
            Console.WriteLine($"The difference between {request.getNumberOne()} and {request.getNumberTwo()}  is : {request.getNumberOne() - request.getNumberTwo()}");
            _nextinchain?.Operation(_request);
        }
    }

    class MultiplicationOperation : IArithmaticOperation
    {
        private static Request _request;
        private static IArithmaticOperation _nextinchain;
        public void setNext(IArithmaticOperation nextInChain)
        {
            _nextinchain = nextInChain;
        }

        public void Operation(Request request)
        {
            _request = request;
            Console.WriteLine($"The product of {request.getNumberOne()} and {request.getNumberTwo()}  is : {request.getNumberOne() * request.getNumberTwo()}");
            _nextinchain?.Operation(_request);
        }
    }

    class DivisionOperation : IArithmaticOperation
    {
        private static Request _request;
        private static IArithmaticOperation _nextinchain;
        public void setNext(IArithmaticOperation nextInChain)
        {
            _nextinchain = nextInChain;
        }

        public void Operation(Request request)
        {
            _request = request;
            Console.WriteLine($"The ratio of {request.getNumberOne()} and {request.getNumberTwo()}  is : {request.getNumberOne() / request.getNumberTwo()}");
            _nextinchain?.Operation(_request);
        }
    }

    //Client
    public class Arithmaticcalculator
    {
        private static int _num1, _num2;
        public Arithmaticcalculator(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public void operationhandler()
        {
            IArithmaticOperation addition = new AdditionOperation();
            IArithmaticOperation subtraction = new SubtractionOperation();
            IArithmaticOperation multiplication = new MultiplicationOperation();
            IArithmaticOperation division = new DivisionOperation();

            addition.setNext(subtraction);
            subtraction.setNext(multiplication);
            multiplication.setNext(division);

            Request request = new Request(_num1, _num2);
            addition.Operation(request);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Arithmaticcalculator calculator = new Arithmaticcalculator(10, 4);
            calculator.operationhandler();
            Console.ReadKey();
        }
    }
    */
}
