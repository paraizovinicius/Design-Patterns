using System.Net;
namespace Mediator
{
    class ConcreteMediator : IMediator
    {

        private ConcreteColleague1 _component1;
        private ConcreteColleague2 _component2;

        public ConcreteMediator(ConcreteColleague1 component1, ConcreteColleague2 component2)
        {
            this._component1 = component1;
            this._component1.SetMediator(this); // first mediator
            this._component2 = component2;
            this._component2.SetMediator(this); // second mediator
        }

        public void Notify(object sender, string evento)
        {
             if (evento == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers folowing operations:");
                this._component2.OperationC();
            }
            if (evento == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                this._component2.OperationC();
            }

        }
    }
}