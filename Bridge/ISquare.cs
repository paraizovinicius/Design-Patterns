using System;
namespace Bridge{
    
    interface ISquare
    {
        // Define the implementation interface, which represents a single square on the game board
        bool IsOccupied();
        void SetOccupant(Player player);
        void ClearOccupant();
        void Print();
        Player GetOccupant();
    }
}

