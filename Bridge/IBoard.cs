using System;
namespace Bridge{
    
    interface Iboard // This interface allows it to refer itself to the concrete classes without knowing them detailedly
    {
        // It defines the abstraction interface which represents the game board
        void MakeMove(int fromRow, int fromCol, int toRow, int toCol);
        void PrintBoard();
    }
}
