namespace Mediator
{
    class ConcreteColleague2 : Colleague
    {

        public void OperationC()
        {
            Console.WriteLine("\nComponent 2 does function C");
            this._mediator.Notify(this, "C"); // object sender, string evento
        }
        public void OperationD()
        {
            Console.WriteLine("\nComponent 2 does function D");
            this._mediator.Notify(this, "D"); // object sender, string evento

        }
    }
}