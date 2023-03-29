using System;
namespace CoR{

    class Program{
        static void Main(String[] args){

        // Cria os handlers
        RequestProcessor handler1 = new ConcreteImpl1();
        RequestProcessor handler2 = new ConcreteImpl2();
        RequestProcessor handler3 = new ConcreteImpl3();

        // Setting the order of the chain
        handler1.SetNextHandler(handler2);
        handler2.SetNextHandler(handler3);

        // Calling the first of the chain each of this requisition numbers
        handler1.HandleRequest(5); // First 'responsible'
        handler1.HandleRequest(15); // Second responsible takes the upper chalenge
        handler1.HandleRequest(25); // Third takes the ultimate chalenge
 
        Console.ReadKey();
        }
    }
}  

    