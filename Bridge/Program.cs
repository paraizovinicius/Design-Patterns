using System;

namespace Bridge
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create the implementation objects
            ISquare[,] board = new ISquare[8, 8];
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0) //every square witch has row + col multiple by 2 is a white one
                    {
                        board[row, col] = new WhiteSquare();
                        if (row < 3)
                        {
                            // Initialize white pieces
                            Player branco = new Player("White");
                            board[row, col].SetOccupant(branco);
                        }
                        else if (row > 4)
                        {
                            // Initialize black pieces
                            Player preto = new Player("Black");
                            board[row, col].SetOccupant(preto);
                        }
                    }
                    else
                    {
                        board[row, col] = new BlackSquare();
                    }
                }
            }
            // Creating the abstraction object
            Iboard gameboard = new Checkers(board);
            gameboard.PrintBoard();
            Console.Write("\n\n");

            // Making some moves to demonstration
            gameboard.MakeMove(2, 0, 3, 0); // from row, from col, to row, to col

            // Printing the gameboard
            gameboard.PrintBoard();
        }
    }

}
