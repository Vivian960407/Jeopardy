using System;

namespace JeopardyAssignment
{
    class Game
    {
        readonly Player my_player = new Player();
        readonly Game_Question my_question = new Game_Question();

        public void Menu_Switch()
        {

            my_question.QuestionMaker();

            while (true)
            {
                Console.WriteLine("Menu. Choose a number corresponding what you want to do from this list:");
                Console.WriteLine("1. Start a new game\n2. Exit game");
                int menuInput = 0;
                try
                {
                    menuInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {

                }

                switch (menuInput)
                {
                    case 1:
                        Start_New_Game();
                        break;
                    case 2:
                        Exit_Game();
                        break;
                    default:
                        Console.WriteLine("Can only choose 1 or 2");
                        Menu_Switch();
                        break;
                }
            }
        }

        public void Start_New_Game()
        {
            my_player.ClearQuestionsCompleted();
            my_question.Question_Remover();
            my_question.Question_Sorter();
            my_player.Points = 0;
            Console.Clear();
            for (int i = 1; i < 6; i++)
            {
                if (i == 5)
                {
                    if (my_player.Points > 0)
                    {
                        Last_Questionnaire();
                    }
                    else
                    {
                        Console.WriteLine("Sorry! You've lost...\n\n\n");
                    }
                }
                Questionnaire();
            }

        }
        public void Exit_Game()
        {
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Press any key to close application");
            Environment.Exit(0);
        }

        public void Questionnaire()
        {
            int choice = 0;
            int index;
            while (true)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Choose category by entering a number between 1 - 5");
                Console.WriteLine("--------------------------------------------------");
                my_question.List_Categories();
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
                index = my_question.Question_Finder(category);
                if (index != -1)
                    break;
            }
            string played_value = my_question.Answer_Checker(index);
            my_player.WinQuestion(played_value);

            my_player.ShowStatistics();
        }

        private void Last_Questionnaire()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Last question, you are now allowed to bet. Enter your bet: ");
            Console.WriteLine("-----------------------------------------------------------");
            int bet = 0;

            while (true)
            {
                try
                {
                    bet = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                }
                if (bet > my_player.Points || bet < 1)
                {
                    Console.WriteLine("You can´t bet more than what you have, please bet again");
                    Console.WriteLine("Place your bet");
                }
                else
                    break;
            }

            my_player.AddBet(bet);
            int choice = 0;
            int index;
            while (true)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Choose category by entering a number between 1 - 5");
                Console.WriteLine("--------------------------------------------------");
                my_question.List_Categories();
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
                index = my_question.Question_Finder(category);
                if (index != -1)
                    break;
            }
            my_question.Answer_Checker(index);
            my_player.WinLastQuestion(bet);
            my_player.ShowEndResult();
        }
    }


    public class Player
    {
        public static int QuestionsCompleted { get; set; }
        public int Points { get; set; }

        public void AddBet(int bet)
        {
            Points -= bet;
        }
        public void ClearQuestionsCompleted()
        {
            QuestionsCompleted = 0;
        }

        public void WinQuestion(string value)
        {
            Points += Int32.Parse(value);
            QuestionsCompleted++;
        }
        public void WinLastQuestion(int bet)
        {
            Points += bet * 2;
        }
        public void ShowEndResult()
        {
            Console.WriteLine("Thanks for playing, yor final score is: {0}\n\n\n", Points);
            ClearQuestionsCompleted();
        }
        public void ShowStatistics()
        {
            Console.WriteLine("Your points: {0}", Points);
            Console.WriteLine("Questions answered {0} of 6", QuestionsCompleted);
        }
    }
}
