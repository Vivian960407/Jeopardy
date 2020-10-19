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
        Game_Question game = new Game_Question();

        public void current_question()
        {
            //Hur svår fråga vill du svara på?
            int value = 0; //läsa in den valda poängen
            int index = game.Random_Q_Generator(value);

            string played_value = game.answer_checker(index);
            my_player.WinQuestion(played_value);
            game.Question_Remover(index);

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
