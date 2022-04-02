using System;

namespace LaddersAndSnakes
{
    class Program
    {
        
        // Builds the board in a single array (board)
        /// <summary>
        /// Board creation
        /// </summary>
        /// <returns>single array with 25 int's</returns>
        private static int[] buildBoard()                // feito por Bruno e Fabio (para o relatorio)
        {
            
            int [] board = new int[25];
            for(int i = 0; i < board.Length; i++)
            {
                board[i] = 0;
            }

            return board;

        }

        //Transforms the single array (board) and prints it in the directions wanted
        /// <summary>
        /// print board with player and without player
        /// </summary>
        /// <param name="board"> Receive board created previously</param>
        private static void printBoard(int[] board)                // feito por Bruno (para o relatorio)
        {
            
            

            //val is 25 - 1
            int val = board.Length-1;
            int invert;

            Console.WriteLine("\n-----------------------------------");  
            //while cycle that checks if the array has ended       
            while (val > -1){
                if (val % 2 == 0){   
                    //invert is -4 when the line starting number is pair                 
                    invert = -4;
                }
                else{
                    //otherwise stays at 0
                    invert = 0;
                }
                //for cycle that starts in the last Index and goes through the array 5 by 5 elements
                for (int i = val; i > val-5; i--)
                {   
                    //Console.Write($"| {i+invert,3:d}  |"); //aparecer os números

                    //if it is a normal tile prints empty
                    if(board[i+invert] == 0)
                    {
                        Console.Write($"| {"",3:d} |");         //Fazer um if para mostrar Snakes and Ladders
                    }
                    //if it is a player tile prints player
                    else
                    {
                        Console.Write($"| {"P"+board[i+invert],2:d}  |"); 
                    }
                    
                    //changes the value of invert according to the array position    
                    if (val % 2 == 0)
                    {
                        invert += 2;
                    }
                }
                Console.WriteLine("\n-----------------------------------");
                val-=5;
            }
            
        }

        /// <summary>
        /// Receive which player is playing and move the number of tiles given by the die
        /// </summary>
        /// <param name="player">Which player</param>
        /// <param name="moveByDie">Number given by the die</param>
        /// <param name="board">Board created by method buildBoard</param>
        private static void movePlayerByDie(int player, int moveByDie, int[] board)
        {   
            //gets the position of the player on the board
            int position = Array.IndexOf(board, player);
            
            
            //if the player is on the board moves normally
            if (position  != -1)       
            {       
                int newPos = position+moveByDie;
                if (newPos > 24) 
                {
                    newPos = 24 - (newPos - 24);
                }
                board[newPos] = player;
                board[position] = 0;


                if (newPos == 24)
                {
                    Console.WriteLine($"Player {player} win!!");
                    
                }
            }


            //if it isn't subtract 1 to the move and gets on the board correctly
            else
            {                                          //se o jogador estiver fora do tabuleiro
                board[moveByDie-1] = player;
                          
                                                        
            }
            
        
        }

        // Roll dice (1 - 6)
        /// <summary>
        ///  Number generator (die) 1-6
        /// </summary>
        /// <returns>random number between 1-6</returns>
        private static int dice()                   /// feito por Fabio (para o relatorio)
        {
            Random rand = new Random();
            int dice = rand.Next(1, 7);
            return dice;
        }


        //makes a player roll the die to make a move
        /// <summary>
        /// Save the generated number by method dice
        /// </summary>
        /// <param name="player">which player</param>
        /// <returns>Saved number by method die</returns>
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
