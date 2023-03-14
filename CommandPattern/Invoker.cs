using System;
namespace CommandPattern
{
    public class Invoker
    {
        private ConcreteCommand _concretecommand;

        public Invoker(ConcreteCommand concretecommand)
        {
            _concretecommand = concretecommand;
        }

        public void Executar()
        {
            _concretecommand.Execute();
        }
    }
}