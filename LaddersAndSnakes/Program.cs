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

        // Roll dice (1 - 6)
        private static int dice()
        {
            Random rand = new Random();
            int dice = rand.Next(1, 7);
            return dice;
        }



        static void Main(string[] args)
        {
            bool winner = false;
            buildBoard();

            //Creates player 1
            string player1 =  "P1";  
            //Creates player 2   
            string player2 =  "P2";     

            //while there isn't a winner runs 
            do
            {
                string input;

                //Asks the player to roll the die
                Console.WriteLine($"{player1}, it's your turn! Press /R to roll the die: ");
                //Reads the input of the player        
                input = Console.ReadLine();  

                //if the input is correct (R or r) rolls the die
                if (input == "r" || input == "R")                                                   
                {
                    //prints the number rolled
                    Console.WriteLine($"Your roll: {dice()}");
                    // meter aqui buildBoard com o movimento do jogador

                }
                //if the input is incorrect asks to press R again with a Error Message
                else
                {
                    Console.WriteLine("Invalid input!!");
                    Console.WriteLine("Please use /R to roll the die ");
                    winner = true;
                }

            }while(winner != true);
            
            
        }
    }
}
