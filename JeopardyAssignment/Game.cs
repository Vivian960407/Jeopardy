using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;

namespace JeopardyAssignment
{
    class Game
    {

        // Game logiken ska byggas här
        // Metoder såsom Menu/Start eller poäng beräkningar ska kodas här
        //UI hanteras här för det mesta 


        Player my_player = new Player();
        Game_Question my_question = new Game_Question();

        public void start()
        {
            my_question.QuestionMaker();
            my_question.Question_Sorter();
            while (true)
            {
                Questionnaire();
            }
        }

        public void Questionnaire()
        {
            Console.WriteLine("Pick a category by entering its number, no parenthesis needed: ");
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
                string played_value = my_question.answer_checker(index);

                if (my_player.Bet != 0 && (Int32.Parse(played_value)) !< 0)
                    my_player.ReturnBet();
                if (my_player.Bet != 0 && (Int32.Parse(played_value)) !> 0)
                {
                    my_player.ClearBet();
                }
                else
                    my_player.WinQuestion(played_value);
            }
        }
    }

   
    public class Player
    {
        public static int QuestionsCompleted { get; set; } = 1;
        public int Points { get; set; } = 100;
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
            return;
        }

        public void ShowStatistics()
        {
            //Console.WriteLine("Bet: {0}", Bet);
            Console.WriteLine("Points: {0}", Points);
            Console.WriteLine("Questions completed: {0}", QuestionsCompleted -1);
        }

    }
}
