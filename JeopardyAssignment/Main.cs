using System.Text;
﻿using System.Security.Cryptography.X509Certificates;


namespace JeopardyAssignment
{
    internal class Program
    {
        public static void NewGame()
        {
            WelcomeMessage.Welcome();
            var game = new Game();
            game.Menu_Switch();
        }
    }
}