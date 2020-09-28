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


            player_Position = 0;
            Console.WriteLine("Current Position of Player is : " + player_Position);
            Random rnd = new Random();
            die_Roll_Number = rnd.Next(1, 7);
            Console.WriteLine("Number getting after Rolling Die is : " + die_Roll_Number);
            snake_Ladder_Options = rnd.Next(1, 4);

            if (snake_Ladder_Options == 1)
            {
                Console.WriteLine("\nNo Play \n");
            }
            else if (snake_Ladder_Options == 2)
            {
                Console.WriteLine("\nLadder: Position incremented by " + die_Roll_Number + "\n");
                player_Position = player_Position + die_Roll_Number;
            }
            else
            {
                Console.WriteLine("\nSnake: Position decremented by " + die_Roll_Number + "\n");
                player_Position = player_Position - die_Roll_Number;
            }

            Console.WriteLine("Player Position after die rolling is  : " + player_Position);

        }
    }
}
