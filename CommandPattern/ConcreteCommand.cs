using System;
namespace CommandPattern
{
    public class ConcreteCommand : Command
    {
        private Receiver Receiver { get; set; }

        private string Acao { get; set; }

        public ConcreteCommand(Receiver receiver, string acao) //Construtor
        {
                Receiver = receiver;
                Acao = acao;
        }

        public override void Execute()
        {
           if (Acao.Equals("Comando A"))
           {
                Receiver.ACommand();
           }
           else
           {
                Receiver.BCommand();
           }
        }
    }
}