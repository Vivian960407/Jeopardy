using System;

namespace JeopardyAssignment
{
    class Game
    {

        // Game logiken ska byggas här
        // Metoder såsom Menu/Start eller poäng beräkningar ska kodas här
        //UI hanteras här för det mesta 

        readonly Player my_player = new Player();
        readonly Game_Question my_question = new Game_Question();

        public void Start()
        {
            my_question.QuestionMaker();
            my_question.Question_Sorter();

            for (int i = 0; i < 5; i++)
            {
                Questionnaire();
            }
            for (int i = 5; i < 6; i++)
            {
                Last_Questionnaire();
            }
        }

        public void Questionnaire()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Choose category by entering a number between 1 - 5");
            Console.WriteLine("--------------------------------------------------");
            my_question.List_Categories();
            int choice = 0;
            while (true)
            {
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                    //DeletePreviousConsoleLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please use correct format");
                }
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Please pick only from the list");
                }
                else
                    break;
            }
            string category = my_question.Category(choice);
            int index = my_question.Question_Finder(category);
            if (index == -1)
                return;
            else
            {
                string played_value = my_question.Answer_Checker(index);
                if (my_player.Bet != 0 && (Int32.Parse(played_value))! < 0)
                    my_player.ReturnBet();
                if (my_player.Bet != 0 && (Int32.Parse(played_value))! > 0)
                {
                    my_player.ClearBet();
                }
                else
                    my_player.WinQuestion(played_value);
            }
            my_player.ShowStatistics();
        }

        private void Last_Questionnaire()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Last question, you are now allowed to bet. Enter your bet: ");
            Console.WriteLine("-----------------------------------------------------------");
            int bet = Convert.ToInt32(Console.ReadLine());
            my_player.AddBet(bet);
            if (bet > my_player.Points)
            {
                Console.WriteLine("You can´t bet more than what you have, please bet again");
                Console.WriteLine("Place your bet");
                Last_Questionnaire();
            }
            Console.WriteLine("Choose category by entering a number between 1 - 5");
            my_question.List_Categories();
            int choice = 0;
            while (true)
            {
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please use correct format");
                }
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Please pick only from the list");
                }
                else
                    break;
            }
            string category = my_question.Category(choice);
            int index = my_question.Question_Finder(category);
            if (index == -1)
                return;
            else
            {
                string played_value = my_question.Answer_Checker(index);

                if (my_player.Bet != 0)
                {
                    my_player.WinLastQuestion(bet++);
                }
            }
            my_player.ShowEndResult();
        }
        //private static void DeletePreviousConsoleLine()
        //{
        //    if (Console.CursorTop == 0) return;
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //    Console.Write(new string(' ', Console.WindowWidth));
        //    Console.SetCursorPosition(0, Console.CursorTop - 1);
        //}
    }


    public class Player
    {
        public static int QuestionsCompleted { get; set; }
        public int Points { get; set; }
        public int Bet { get; set; }

        public void AddBet(int bet)
        {
            Bet += bet;
            Points -= bet;
        }

        public void ClearBet()
        {
            Bet = 0;
        }

        public void ReturnBet()
        {
            Points += Bet;
            ClearBet();
        }

        public void WinQuestion(string value)
        {
            Points += Int32.Parse(value);
            QuestionsCompleted++;
        }
        public void WinLastQuestion(int bet)
        {
            Points += Bet * 2;
        }
        public void ShowEndResult()
        {
            Console.WriteLine("Thanks for playing, yor final score is: {0}", Points);
        }
        public void ShowStatistics()
        {
            Console.WriteLine("Your points: {0}", Points);
            Console.WriteLine("Questions answered {0} of 6", QuestionsCompleted);
        }

    }
}
