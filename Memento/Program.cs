using System;
namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um objeto originator
            var originator = new Originator();

            // Cria um objeto caretaker e passa o originator
            var caretaker = new Caretaker(originator);

            // Muda o estado do originator e faz o backup
            originator.SetState("Estado 1");
            caretaker.Backup();

            // Muda o estado do originator novamente e faz o backup
            originator.SetState("Estado 2");
            caretaker.Backup();

            // Muda o estado do originator novamente e faz o backup
            originator.SetState("Estado 3");
            caretaker.Backup();

            // Restaura o estado anterior salvo .. estado 2
            caretaker.Undo(); // Imprime "Caretaker: Restaurando estado do Originator..."

            // Muda o estado do originator pela última vez e não faz o backup
            originator.SetState("Estado 3");

            // Restaura o estado anterior salvo .. estado 1
            caretaker.Undo();

            Console.ReadKey();
        }
    }
}
