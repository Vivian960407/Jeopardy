using System;
using System.IO;

namespace Jeopardy
{
    internal class Questions
    {
        public string Text { get; set; }
        public static bool FromMain(string game_Season)
        {
            bool GameRunning = true;
            while (GameRunning)
            {
                try
                {
                    string path = @"C:\Users\marcu\source\repos\Jeopardy\jeopardy_clue_dataset-master\" + game_Season + ".tsv";
                    string Text = File.ReadAllText(path);

                    Console.WriteLine("Content of file:");
                    Console.WriteLine(game_Season);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occured: " + e.Message);
                }
            }
            return false;

        }
    }
}
