using System;
using System.Collections.Generic;
namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaf1 = new Leaf1();
            var leaf2 = new Leaf1();
            var composite = new ConcreteComponent();
            composite.Add(leaf1);
            composite.Add(leaf2);

            var composite2 = new ConcreteComponent();
            var leaf3 = new Leaf1();
            composite2.Add(composite);
            composite2.Add(leaf3);

            // Usando a estrutura com um cliente
            var client = new Client(composite2);
            client.DoOperation();
        }
    }
}