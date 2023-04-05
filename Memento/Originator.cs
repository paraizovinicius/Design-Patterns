using System;
namespace Memento
{
    // Objeto a ser salvo/armazenado
    // Cria um memento contendo um snapshot do estado interno atual
    // Usa o memento pra recuperar este estado interno
    class Originator 
    {
        private string? _state;

        public void SetState(string state)
        {
            Console.WriteLine("\nOriginator: Mudando estado para " + state);
            _state = state;
        }

        public Memento SaveStateToMemento()
        {
            Console.WriteLine("\nOriginator: Salvando estado no Memento.");
            return new Memento(_state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            _state = memento.GetState(); // Vai pegar o state armazenado na classe Memento
            Console.WriteLine("\nOriginator: Estado após restauração: " + _state);
        }
    }
}
