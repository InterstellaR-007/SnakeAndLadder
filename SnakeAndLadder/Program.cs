using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int next_Chance = 0 ;
            int playerWon = 0;
            int die_Roll_Number_p1;
            int snake_Ladder_Options_p1;
            int player_Position_p1;
            int count_p1=0;
            player_Position_p1 = 0;

            int die_Roll_Number_p2;
            int snake_Ladder_Options_p2;
            int player_Position_p2;
            int count_p2 = 0;
            player_Position_p2 = 0;

            while (player_Position_p1 != 100 && player_Position_p2 != 100)
            {
                Random rnd = new Random();
                if (next_Chance != 1)
                {
                    Console.WriteLine("\nCurrent Position of Player1 is : " + player_Position_p1);

                    die_Roll_Number_p1 = rnd.Next(1, 7);
                    count_p1 = count_p1 + 1;
                    Console.WriteLine("Number getting after Rolling Die for Player1 is : " + die_Roll_Number_p1);
                    snake_Ladder_Options_p1 = rnd.Next(1, 4);

                    if (snake_Ladder_Options_p1 == 1)
                    {
                        Console.WriteLine("\n No Play \n");
                        next_Chance = 0;
                    }
                    else if (snake_Ladder_Options_p1 == 2)
                    {
                        Console.WriteLine("\n Ladder: Position of Player1 incremented by " + die_Roll_Number_p1 + "\n");
                        player_Position_p1 = player_Position_p1 + die_Roll_Number_p1;
                        if (player_Position_p1 > 100)
                        {
                            player_Position_p1 = player_Position_p1 - die_Roll_Number_p1;
                        }
                        next_Chance = 1;
                    }
                    else
                    {
                        Console.WriteLine("\n Snake: Position of Player 1 decremented by " + die_Roll_Number_p1 + "\n");
                        player_Position_p1 = player_Position_p1 - die_Roll_Number_p1;
                        if (player_Position_p1 < 0)
                        {
                            player_Position_p1 = 0;

                        }
                        next_Chance = 0;
                    }
                    Console.WriteLine("Player Position of Player1 after die rolling is  : " + player_Position_p1);
                    if (player_Position_p1 == 100)
                    {
                        playerWon = 1;
                        break;
                    }


                    

                }
                else
                    next_Chance = 0;

                if (next_Chance != 1)
                {
                    Console.WriteLine("\nCurrent Position of Player2 is : " + player_Position_p2);

                    die_Roll_Number_p2 = rnd.Next(1, 7);
                    count_p2 = count_p2 + 1;
                    Console.WriteLine("Number getting after Rolling Die for Player2 is : " + die_Roll_Number_p2);
                    snake_Ladder_Options_p2 = rnd.Next(1, 4);

                    if (snake_Ladder_Options_p2 == 1)
                    {
                        Console.WriteLine("\n No Play \n");
                        next_Chance = 0;
                    }
                    else if (snake_Ladder_Options_p2 == 2)
                    {
                        Console.WriteLine("\n Ladder: Position of Player2 incremented by " + die_Roll_Number_p2 + "\n");
                        player_Position_p2 = player_Position_p2 + die_Roll_Number_p2;
                        if (player_Position_p2 > 100)
                        {
                            player_Position_p2 = player_Position_p2 - die_Roll_Number_p2;
                        }
                        next_Chance = 1;
                    }
                    else
                    {
                        Console.WriteLine("\n Snake: Position of Player 2 decremented by " + die_Roll_Number_p2 + "\n");
                        player_Position_p2 = player_Position_p2 - die_Roll_Number_p2;
                        if (player_Position_p2 < 0)
                        {
                            player_Position_p2 = 0;
                        }
                        next_Chance = 0;
                    }

                    Console.WriteLine("Player Position of Player2 after die rolling is  : " + player_Position_p2);
                    if (player_Position_p2 == 100)
                    {
                        playerWon = 2;
                        break;
                    }

                    
                }
                else
                    next_Chance = 0;
            }
            Console.WriteLine("Player" + playerWon+" has won the game");

        }
                

        }
    }

