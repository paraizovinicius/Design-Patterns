using System;
using System.Collections.Generic;

// Gives Memento back to Originator to restaure the internal state // Backup
namespace Memento
{
    class Caretaker
    {
        // This list only can keep Memento objects
        private List<Memento> _mementos = new List<Memento>(); 
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving state of Originator...");
            _mementos.Add(_originator.SaveStateToMemento());
        }

        public void Undo()
        {
            // Verify if there's mementos kept in the list
            if (_mementos.Count == 0)
            {
                return; // If not, exits method
            }


            // Obtains the penultimate memento of the list
            var memento = _mementos[_mementos.Count - 2];

            // Removes the last memento of the list
            _mementos.RemoveAt(_mementos.Count - 1);

            // Prints a message indicating that the state of Originator is being restaured
            Console.WriteLine("\nCaretaker: Restauring Originator state...");

            // Restaures the state of Originator from the obtained penultimate memento
            _originator.GetStateFromMemento(memento);
        }

    }

}