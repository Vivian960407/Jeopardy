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

        public static void WinQuestion(string value)
        {
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
