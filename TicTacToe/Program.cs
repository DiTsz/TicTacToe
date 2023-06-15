using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sign = 'X';
            Console.WriteLine(
                "Welcome to the TicTacToe game!\n" +
                "Now the field is empty:\n");
            Console.WriteLine(
                "\t" + "   |   |   \n" +
                "\t" + "---+---+---\n" +
                "\t" + "   |   |   \n" +
                "\t" + "---+---+---\n" +
                "\t" + "   |   |   \n");
            Console.WriteLine("The game begins! Now you can play with X only");

            void SetSign()
            {
                Console.Write("Choose the raw: ");
                uint raw = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Choose the column: ");
                uint col = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
