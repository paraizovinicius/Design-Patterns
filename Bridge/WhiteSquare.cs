using System;
namespace Bridge{

    
    class WhiteSquare : ISquare{
        // Concrete implementation class, which represent white squares on the game board
        private Player? occupant; // The interrogation declares that this variable could be nullable

        public WhiteSquare() // this is to guarantee that when the game starts, all squares are null
        {
            occupant = null;
        }

        public bool IsOccupied()
        {
            return (occupant != null);
        }

        public Player GetOccupant()
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