using System;
namespace Adapter{

    class Program{
        static void Main(string[] args){
            Adaptee tobeadapted = new Adaptee();
            Target target = new Adapter(tobeadapted);

            Console.WriteLine("Adaptee is incompatible");

            Console.WriteLine(target.Request());
         
        }
    }
}