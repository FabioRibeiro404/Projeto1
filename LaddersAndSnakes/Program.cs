using System;

namespace LaddersAndSnakes
{
    class Program
    {
        // Build board
        private static void buildBoard()
        {
            int [,] board = new int [5,5];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write($"| {board[i,j]} |");
                }
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
            }
        }
        static void Main(string[] args)
        {
            buildBoard();
            
        }
    }
}
