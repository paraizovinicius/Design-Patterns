
namespace Mediator{
    class Program{
        static void Main(string[] args)
        {
            ConcreteColleague1 componente1 = new ConcreteColleague1();
            ConcreteColleague2 componente2 = new ConcreteColleague2();

            new ConcreteMediator(componente1, componente2);


            Console.WriteLine("Client triggers A");
            componente1.OperationA();

            Console.WriteLine();

            Console.WriteLine("Client triggers D");
            componente2.OperationD();


        }
    }
}