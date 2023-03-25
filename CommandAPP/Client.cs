using System;
namespace CommandAPP
{
    public class Client{

    static void Main(String[] args)
    {

        Console.WriteLine("Command Pattern\n");

        Receiver receiver = new Receiver();

        // Comando A
        ConcreteCommand concretecommand = new ConcreteCommand(receiver, "Comando A");
        Invoker invoke = new Invoker(concretecommand);
        invoke.Executar();


        ConcreteCommand concretecommand2 = new ConcreteCommand(receiver, "Comando B");
        Invoker invoke2 = new Invoker(concretecommand2);
        invoke2.Executar();

        Console.ReadKey();
    }
    }
}

