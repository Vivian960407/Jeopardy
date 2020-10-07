using System;
using System.Collections.Generic;
using System.IO;

namespace Jeopardy
{
    internal class Add_Questions
    {
        public static void File_Location(string game_Season) {
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
            return;
            
        }
        public static List<string> AvailableSeasons { get; } = new List<string>();
        public static void Add_Question()
        {
            AvailableSeasons.Add("season1");
            AvailableSeasons.Add("season2");
            AvailableSeasons.Add("season3");
            AvailableSeasons.Add("season4");
            AvailableSeasons.Add("season5");
            AvailableSeasons.Add("season6");
            AvailableSeasons.Add("season7");
            AvailableSeasons.Add("season8");
            AvailableSeasons.Add("season9");
            AvailableSeasons.Add("season10");
            AvailableSeasons.Add("season11");
            AvailableSeasons.Add("season12");
            AvailableSeasons.Add("season13");
            AvailableSeasons.Add("season14");
            AvailableSeasons.Add("season15");
            AvailableSeasons.Add("season16");
            AvailableSeasons.Add("season17");
            AvailableSeasons.Add("season18");
            AvailableSeasons.Add("season19");
            AvailableSeasons.Add("season20");
            AvailableSeasons.Add("season21");
            AvailableSeasons.Add("season22");
            AvailableSeasons.Add("season23");
            AvailableSeasons.Add("season24");
            AvailableSeasons.Add("season25");
            AvailableSeasons.Add("season26");
            AvailableSeasons.Add("season27");
            AvailableSeasons.Add("season28");
            AvailableSeasons.Add("season29");
            AvailableSeasons.Add("season30");
            AvailableSeasons.Add("season31");
            AvailableSeasons.Add("season32");
            AvailableSeasons.Add("season33");
            AvailableSeasons.Add("season34");
            AvailableSeasons.Add("season35");
            AvailableSeasons.Add("season36");
        }

        public static void Show_Supported_Seasons()
        {
            Console.WriteLine("Seasons available:");
            string AvailableString = string.Join(", ", AvailableSeasons.ToArray());
            Console.WriteLine(AvailableString);
        }

        public static bool Supported(string Question)
        {
            bool success = false;
            foreach (string question in AvailableSeasons)
            {
                if (Question.Contains(question))
                {
                    success = true;
                }
            }
            return success;
        }
        public Dictionary<string, int> Text_In_File { get; set; }
    }
}

