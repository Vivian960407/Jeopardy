using System;

namespace Jeopardy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool game_Is_Running = true;
            Console.WriteLine("JEOPARDY");
            Add_Questions.Show_Supported_Seasons();
            while (game_Is_Running)
            {
                Console.WriteLine("Select season to play:");
                string game_Season = Console.ReadLine().ToLower();


                if (Add_Questions.Supported(game_Season) == true)
                {
                    bool exitProgram = Add_Questions.Supported(game_Season);
                    if (exitProgram)
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Select one of the supported seasons");
                }

            }

        }
    }
}
