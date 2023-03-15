// See https://aka.ms/new-console-template for more information
using System;
namespace CommandAPP
{
    static void Main(String[] args)
    {

        Console.WriteLine("Command Pattern\n");
        
        Receiver receiver = new Receiver();

        // Comando A
        ConcreteCommand concretecommand = new ConcreteCommand(receiver, "Comando A");
        Invoker invoke = new Invoker(concretecommand);
        invoke.Executar();

        // Comando B
        ConcreteCommand concretecommand = new ConcreteCommand(receiver, "Comando B");
        Invoker invoke = new Invoker(concretecommand);
        invoke.Executar();

        Console.ReadKey();
    }
}

