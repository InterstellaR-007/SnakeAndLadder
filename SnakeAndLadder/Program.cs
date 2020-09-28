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

        }
    }
}
