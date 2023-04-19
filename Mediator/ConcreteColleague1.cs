using System;
namespace Mediator
{
    class ConcreteColleague1 : Colleague
    {


        public void OperationA()
        {
            Console.WriteLine("\nComponent 1 does function A");
            this._mediator.Notify(this, "A"); // object sender, string evento

            // `this` refers to Mediator.ConcreteColleague1
        }

        public void OperationB()
        {
            Console.WriteLine("\nComponent 1 does function B");
            this._mediator.Notify(this, "B");
        }
    }
}