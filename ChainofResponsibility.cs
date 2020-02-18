/* -------------------------------------------------
 * Behaviour Pattern ---- Chain of Responsibility 
 * -------------------------------------------------
 * Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
 * Chain the receiving objects and pass the request along the chain until an object handles it.
 * This pattern has 3 components -  A handler, Concrete Handlers, Client
 * 
 * 1. Handler :           This can be an interface or an abstract class which recieves a request and dispatches the request to the chain of handlers.
 *                        It refers to ONLY THE FIRST handler in the chain and does not know anything about rest of the handlers.
 * 2. Concrete handlers : These are the actual handlers of the request chained in a sequential order. The order is determined by THE CLIENT.
 * 3. Client :            Client is the originator of a request and accesses the handler to handle it.
 */

using System;

namespace DesignPatternPlayground
{
    //1. Handler
    interface IArithmaticOperation
    {
        public void setNext(IArithmaticOperation nextInChain);
        public void Operation(Request request);
    }

    // Context
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

    //2. Concrete Handler One
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
    //2. Concrete Handler Two
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
    //2. Concrete Handler Three
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
    //2. Concrete Handler Four
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

    //3. Client
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
    // Calls the client
    public class ChainofResponsibility
    {
        public static void MainCaller()
        {
            Arithmaticcalculator calculator = new Arithmaticcalculator(10, 4);
            calculator.operationhandler();
        }
    }

}
