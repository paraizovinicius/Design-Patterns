using System;
namespace Bridge{
    
    interface Iboard
    {
        // It defines the abstraction interface which represents the game board
        void MakeMove(int fromRow, int fromCol, int toRow, int toCol);
        void PrintBoard();
    }
}
