using System;
using System.Threading;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] field = new char[3, 3];
        static void Main(string[] args)
        {
            int row;
            int col;

            Console.WriteLine(
                "Welcome to the TicTacToe game!\n" +
                "Now the field is empty:\n");

            Console.Write("\t" + "   |   |   \n");
            Console.Write("\t" + "---+---+---\n");
            Console.Write("\t" + "   |   |   \n");
            Console.Write("\t" + "---+---+---\n");
            Console.Write("\t" + "   |   |  \n");
            Console.WriteLine();

            CellChoice();
            Board();

            void Board()
            {
                Console.Write("\t" + " {0}  | {1} | {2}  \n", field[0, 0], field[0, 1], field[0, 2]);
                Console.Write("\t" + "---+---+---\n");
                Console.Write("\t" + " {0}  | {1}  | {2}  \n", field[1, 0], field[1, 1], field[1, 2]);
                Console.Write("\t" + "---+---+---\n");
                Console.WriteLine("\t" + " {0}  | {1}  | {2}  \n", field[2, 0], field[2, 1], field[2, 2]);
            }
            Console.ReadLine();

            // choose the cell

            void CellChoice()
            {
                Console.WriteLine("Choice");
                Console.Write("Row: ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Column: ");
                col = int.Parse(Console.ReadLine());
                field[row-1, col-1] = 'X';
            }

            
           

            // 1 or 2 players


            // peremoha algorythm
           



        }
    }
}
