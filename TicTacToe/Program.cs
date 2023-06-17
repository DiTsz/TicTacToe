using System;

namespace TicTacToe
{
    class Program
    {
        // creat a board with rows and columns
        static char[,] board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        // X is set by default, his move is the first move
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            bool gameFinished = false;

            while (!gameFinished)
            {
                // shows empty board
                Board();

                // choosing a cell to put X or O in
                Console.WriteLine("Player {0}, choose the cell.", currentPlayer);
                Console.Write("Row: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Column: ");
                int col = int.Parse(Console.ReadLine());

                if (IsValidMove(row, col))
                {
                    board[row - 1, col - 1] = currentPlayer;
                    if (IsWinningMove())
                    {
                        Board();
                        Console.WriteLine("Player {0} wins!", currentPlayer);
                        gameFinished = true;
                    }
                    else if (IsBoardFull())
                    {
                        Board();
                        Console.WriteLine("It's a draw!");
                        gameFinished = true;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void Board()
        {
            Console.Clear();
            Console.WriteLine(" {0} | {1} | {2} ", board[0,0], board[0,1], board[0,2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[1,0], board[1,1], board[1,2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[2,0], board[2,1], board[2,2]);
        }

        // check, whether the move is appropriate
        static bool IsValidMove(int r, int c)
        {
            if ((r < 1 || r > 3) && (c < 1 || c > 3) || (board[r - 1, c - 1] != ' '))
            {
                return false;
            }
            return true;
        }

        static bool IsWinningMove()
        {
            // Check rows
            
            for (int j = 0; j < 3; j++)
            {
                if (board[0,j] == currentPlayer && board[1,j] == currentPlayer && board[2,j] == currentPlayer)
                    return true;
            }
            

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i,0] == currentPlayer && board[i,1] == currentPlayer && board[i,2] == currentPlayer)
                    return true;
            }

            // Check diagonals
            if ((board[0,0] == currentPlayer && board[1,1] == currentPlayer && board[2,2] == currentPlayer) ||
                (board[0,2] == currentPlayer && board[1,1] == currentPlayer && board[2,0] == currentPlayer))
                return true;

            return false;
        }

        // if the board is full, but there is no winner, the game must stop in a draw 
        static bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }
    }
}
