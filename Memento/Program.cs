using System;
namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an originator objet
            var originator = new Originator();

            // Creates a caretaker object and passes the originator object
            var caretaker = new Caretaker(originator);

            // Creates a state for originator and does the backup/save in Caretaker list
            originator.SetState("Estado 1");
            caretaker.Backup();

            // Creates a state for originator and does the backup/save in Caretaker list
            originator.SetState("Estado 2");
            caretaker.Backup();

            // Creates a state for originator and does the backup/save in Caretaker list
            originator.SetState("Estado 3");
            caretaker.Backup();

            // Restauring the previous saved state, witch is state 2
            caretaker.Undo(); // Print "Caretaker: Restauring state from Originator..."

            // Changes the state from Originator for the last time and does not the backup
            originator.SetState("Estado 3");

            // Restauring the previous saved state, witch is state 1
            caretaker.Undo();

            Console.ReadKey();
        }
    }
}
