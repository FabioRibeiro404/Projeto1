using System;

namespace LaddersAndSnakes
{
    class Program
    {
        // Build board definir tamanho 
        private static int[] buildBoard()                /// feito por Fabio (para o relatorio)
        {
            /*
            int[][] board = new int[5][];
            board[0] = new int[5] {2, 0, 0, 0, 0};
            board[1] = new int[5] {0, 0, 0, 1, 0};
            board[2] = new int[5] {2, 1, 0, 2, 0};
            board[3] = new int[5] {0, 0, 0, 1, 0};
            board[4] = new int[5] {2, 0, 0, 1, 0};
            */

            int [] board = new int[25];
            for(int i = 0; i < board.Length; i++)
            {
                board[i] = 0;
            }

            return board;

        }

        private static void printBoard()                /// feito por Fabio (para o relatorio)
        {
            
            //Bruno
            //ladders = 0;
            //Bruno
            //snakes = 0;

            int [] board = buildBoard();
            int val = board.Length-1;
            int invert = val;
            Console.WriteLine("\n-----------------------------------");
            board[16] = 1;
            while (val >-1){
                if (val%2 == 0){                    
                    invert = -4;
                }
                else{
                    invert = 0;
                }
                for (int i = val; i > val-5; i--)
                {   Console.Write($"| {i,3:d}  |"); //aparecer os números
                    /*if(board[i] == 0)
                    {
                        Console.Write($"| {"",3:d} |");
                    }
                    else
                    {
                        Console.Write($"| {"P"+board[i+invert],2:d}  |"); //aparecer se o jogador tiver no quadrado
                    } */
                    if (val%2 == 0){
                        invert+=2;
                    }
                }
                Console.WriteLine("\n-----------------------------------");
                val-=5;
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
            int roll = dice();
            
            
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
                Console.WriteLine($"{player} roll: {roll}");
                
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
            return roll;
            
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
                

                int moveByDie;
                
                moveByDie = playerRoll(player1);
                printBoard();
                
                

                



                moveByDie = playerRoll(player2);
                
                //buildBoard

            }while(winner != true);
            
        }
    }
}
