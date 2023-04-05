using System;
using System.Collections.Generic;

// Fornece ao Memento de volta ao Originator para restaurar o estado interno // Backup
namespace Memento
{
    class Caretaker
    {
        private List<Memento> _mementos = new List<Memento>();
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Salvando estado do Originator...");
            _mementos.Add(_originator.SaveStateToMemento());
        }

        public void Undo()
        {
            // Verifica se há mementos armazenados na lista
            if (_mementos.Count == 0)
            {
                return; // Se não houver, sai do método
            }


            // Obtém o penúltimo memento da lista
            var memento = _mementos[_mementos.Count - 2];

            // Remove o último memento da lista
            _mementos.RemoveAt(_mementos.Count - 1);

            // Imprime uma mensagem indicando que o estado do Originator está sendo restaurado
            Console.WriteLine("\nCaretaker: Restaurando estado do Originator...");

            // Restaura o estado do Originator a partir do memento obtido
            _originator.GetStateFromMemento(memento);
        }

    }

}