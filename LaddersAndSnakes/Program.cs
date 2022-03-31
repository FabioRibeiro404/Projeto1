using System;

namespace LaddersAndSnakes
{
    class Program
    {
        // Builds the board in a single array (board)
        private static int[] buildBoard()                /// feito por Bruno e Fabio (para o relatorio)
        {
            
            int [] board = new int[25];
            for(int i = 0; i < board.Length; i++)
            {
                board[i] = 0;
            }

            return board;

        }

        //Transforms the single array (board) and prints it in the directions wanted
        private static void printBoard(int[] board)                /// feito por Bruno (para o relatorio)
        {
            
            //Bruno
            //ladders = 0;
            //Bruno
            //snakes = 0;

            //val is 25 - 1
            int val = board.Length-1;
            int invert;

            Console.WriteLine("\n-----------------------------------");  
            //while cycle that checks if the array has ended       
            while (val >-1){
                if (val%2 == 0){   
                    //invert is -4 when the line starting number is pair                 
                    invert = -4;
                }
                else{
                    //otherwise stays at 0
                    invert = 0;
                }
                for (int i = val; i > val-5; i--)
                {   //Console.Write($"| {i+invert,3:d}  |"); //aparecer os números
                    if(board[i+invert] == 0)
                    {
                        Console.Write($"| {"",3:d} |");
                    }
                    else
                    {
                        Console.Write($"| {"P"+board[i+invert],2:d}  |"); //aparecer se o jogador tiver no quadrado
                    } 
                    if (val%2 == 0){
                        invert+=2;
                    }
                }
                Console.WriteLine("\n-----------------------------------");
                val-=5;
            }
            
        }

        private static void movePlayerByDie(int player, int moveByDie, int[] board)
        {   
            //vai buscar a posicao do player no array
            int position = Array.IndexOf(board, player);
            if (position  != -1)       //se o jogador já estiver no tabuleiro
            {       
                board[position+moveByDie] = player;
                board[position] = 0;
            }
            else
            {                                          //se o jogador estiver fora do tabuleiro
                board[moveByDie-1] = player;
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
        private static int playerRoll(int player)   /// feito por Bruno (para o relatorio)
        {
            string input;
            bool played = false;
            int roll = dice();
            
            
            do
            {
                //Asks the player to roll the die
            Console.WriteLine($"Player{player}, it's your turn! Press /R to roll the die: ");
            //Reads the input of the player        
            input = Console.ReadLine();  

            //if the input is correct (R or r) rolls the die
            if (input == "r" || input == "R")                                                   
            {
                //prints the number rolled
                Console.WriteLine($"Player{player} roll: {roll}");
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
            int[] board = buildBoard();

            //Creates player 1
            int player1 =  1;  
            //Creates player 2   
            int player2 =  2;  

            int moveByDie;
             


            
            printBoard(board);
            //while there isn't a winner runs 
            do                                      /// feito por Bruno (para o relatorio)
            {
                

                
                
                moveByDie = playerRoll(player1);

                movePlayerByDie(player1, moveByDie, board);
                printBoard(board);
                
                

                



                moveByDie = playerRoll(player2);
                movePlayerByDie(player2, moveByDie, board);
                printBoard(board);
                
                //buildBoard

            }while(winner != true);
            Console.WriteLine($"Congratulations!! Player WON");
            
        }
    }
}
