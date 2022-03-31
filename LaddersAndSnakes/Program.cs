using System;

namespace LaddersAndSnakes
{
    class Program
    {
        // Build board definir tamanho 
        private static void buildBoard()
        {
            
            int[][] board = new int[5][];
            board[0] = new int[5] {2, 0, 0, 0, 0};
            board[1] = new int[5] {0, 0, 0, 1, 0};
            board[2] = new int[5] {2, 1, 0, 2, 0};
            board[3] = new int[5] {0, 0, 0, 1, 0};
            board[4] = new int[5] {2, 0, 0, 1, 0};

        }

        private static void printBoard()
        {
            int [,] board = new int [5,5];
            //Bruno
            //ladders = 0;
            //Bruno
            //snakes = 0;

            Console.WriteLine("-------------------------");

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    
                    board[i,j] = 0;
                    Console.Write($"| {board[i,j]} |");
                    
                }
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
            }
        }

        // Roll dice (1 - 6)
        private static int dice()
        {
            Random rand = new Random();
            int dice = rand.Next(1, 7);
            return dice;
        }


        
        static void Main(string[] args)
        {
            buildBoard();
            
        }
    }
}
