using System;
namespace CommandPattern
{
    public class Receiver
    {

        public void ACommand()
        {
            Console.WriteLine("Função A executada!");
        }

        public void BCommand()
        {
            Console.WriteLine("Função B executada!");
        }
        
    }
}