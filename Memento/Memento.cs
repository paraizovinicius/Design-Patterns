using System;

// Representa um estado armazenado
// Armazena o estado interno do objeto Originator
namespace Memento{
    class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }

    }
}