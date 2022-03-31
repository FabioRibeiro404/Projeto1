using System;

namespace LaddersAndSnakes
{
    class Program
    {
        // Build board definir tamanho 
        private static void buildBoard()                /// feito por Fabio (para o relatorio)
        {
            
            int[][] board = new int[5][];
            board[0] = new int[5] {2, 0, 0, 0, 0};
            board[1] = new int[5] {0, 0, 0, 1, 0};
            board[2] = new int[5] {2, 1, 0, 2, 0};
            board[3] = new int[5] {0, 0, 0, 1, 0};
            board[4] = new int[5] {2, 0, 0, 1, 0};

        }

        private static void printBoard()                /// feito por Fabio (para o relatorio)
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
        private static int dice()                   /// feito por Fabio (para o relatorio)
        {
            Random rand = new Random();
            int dice = rand.Next(1, 7);
            return dice;
        }

        ///makes a player roll the die to make a move
        private static int playerRoll(string player) /// feito por Bruno (para o relatorio)
        {
            string input;
            bool played = false;
            int val = 0;
            
            do
            {
                //Asks the player to roll the die
            Console.WriteLine($"{player}, it's your turn! Press /R to roll the die: ");
            //Reads the input of the player        
            input = Console.ReadLine();  

            //if the input is correct (R or r) rolls the die
            if (input == "r" || input == "R")                                                   
            {
                //prints the number rolled
                Console.WriteLine($"Your roll: {dice()}");
                
                // meter aqui buildBoard com o movimento do jogador
                break;
                
            }
            //if the input is incorrect asks to press R again with a Error Message
            else
            {
                Console.WriteLine("Invalid input!!");
                Console.WriteLine("Please use /R to roll the die ");
            }
            
            //changes boolean to true so it can stop the cycle
            played = true;
            

            }while (played == true);

            //returns the number rolled in the die
            return val;
            
        }


        
        static void Main(string[] args)
        {
            bool winner = false;                    /// feito por Bruno (para o relatorio)
            buildBoard();

            //Creates player 1
            string player1 =  "P1";  
            //Creates player 2   
            string player2 =  "P2";     

            //while there isn't a winner runs 
            do                                      /// feito por Bruno (para o relatorio)
            {
                
                playerRoll(player1);
                //buildBoard



                playerRoll(player2);
                //buildBoard

            }while(winner != true);
            
        }
    }
}
