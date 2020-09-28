using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int die_Roll_Number;
            int snake_Ladder_Options;
            int player_Position;
            int count=0;

            player_Position = 0;

            while (player_Position != 100)
            {

                Console.WriteLine("\nCurrent Position of Player is : " + player_Position);
                Random rnd = new Random();
                die_Roll_Number = rnd.Next(1, 7);
                count = count + 1;
                Console.WriteLine("Number getting after Rolling Die is : " + die_Roll_Number);
                snake_Ladder_Options = rnd.Next(1, 4);

                if (snake_Ladder_Options == 1)
                {
                    Console.WriteLine("\n No Play \n");
                }
                else if (snake_Ladder_Options == 2)
                {
                    Console.WriteLine("\n Ladder: Position incremented by " + die_Roll_Number + "\n");
                    player_Position = player_Position + die_Roll_Number;
                    if (player_Position > 100)
                    {
                        player_Position = player_Position - die_Roll_Number;
                    }
                }
                else
                {
                    Console.WriteLine("\n Snake: Position decremented by " + die_Roll_Number + "\n");
                    player_Position = player_Position - die_Roll_Number;
                    if (player_Position < 0)
                    {
                        player_Position = 0;
                    }
                }
                
                

                Console.WriteLine("Player Position after die rolling is  : " + player_Position);

            }
                Console.WriteLine("\n Number of Times Dice is rolled   : " + count);

        }
    }
}
