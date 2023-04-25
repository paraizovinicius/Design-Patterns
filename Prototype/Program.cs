using System;
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House();
            h1.AddressNumber = 63;
            h1.StreetAddress = "Rua Conde de Bonfim";
            h1._register = new Register(6927398);

            House h2 = h1.Copy();
            Console.WriteLine(h2.StreetAddress);
            Console.WriteLine();
            Console.WriteLine(h2.AddressNumber);
            Console.WriteLine();
            Console.WriteLine(h2.Register._register);
        }
    }
}