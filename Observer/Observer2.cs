using System;
using System.Collections.Generic;
namespace Observer{
    class Observer2 : Observador
    {
        public void Update(int value) // Implementar o método Update da interface Observador
        {
            Console.WriteLine("Class2 - Value now altered to: " + value); 
        }
    }
}

