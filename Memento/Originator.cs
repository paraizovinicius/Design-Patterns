using System;
namespace Memento
{
    // Object to be saved/kept
    // Creates a memento containing a snapshot of actual internal state
    // Uses the memento to retrieve the internal state
    class Originator 
    {
        private string? _state;

        public void SetState(string state)
        {
            Console.WriteLine("\nOriginator: Changing state to " + state);
            _state = state;
        }

        public Memento SaveStateToMemento()
        {
            Console.WriteLine("\nOriginator: Change state in Memento.");
            return new Memento(_state); //item to be added in the caretaker list
        }

        public void GetStateFromMemento(Memento memento)
        {
            _state = memento.GetState(); // GetState kept in Memento class
            Console.WriteLine("\nOriginator: State restaured: " + _state);
        }
    }
}
