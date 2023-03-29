using System;
namespace Bridge{

    
    class BlackSquare : ISquare
    {
        // Concrete implementation class, which represent black squares on the game board
        private Player? occupant; // The interrogation declares that this variable could be nullable

        public BlackSquare()
        {
            occupant = null;
        }

        public bool IsOccupied()
        {
            return (occupant != null);
        }

        public Player GetOccupant() //
        {
            return occupant;
        }

        public void SetOccupant(Player player)
        {
            occupant = player;
        }

        public void ClearOccupant()
        {
            occupant = null;
        }

        public void Print()
        {
            if (IsOccupied())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("(O)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("( )");
            }
        }
    }

}