using System;
namespace Bridge
{

    class Checkers : Iboard
    {
        // It defines the client class which creates and uses the abstraction and implementation objects
        private ISquare[,] board;

        public Checkers(ISquare[,] board)
        {
            this.board = board;
        }

        public void MakeMove(int fromRow, int fromCol, int toRow, int toCol)
        {
            // Make the move on the board
            ISquare fromSquare = board[fromRow, fromCol];
            ISquare toSquare = board[toRow, toCol];

            if (fromSquare.IsOccupied() && !toSquare.IsOccupied())
            {
                Player player = fromSquare.GetOccupant();
                fromSquare.ClearOccupant();
                toSquare.SetOccupant(player);
            }
        }

        public void PrintBoard()  // Print the board to the console
        {
            
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    board[row, col].Print();
                }

                Console.WriteLine();
            }
        }
    }
}
