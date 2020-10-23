namespace JeopardyAssignment
{
    internal class Program
    {
        public static void Main()
        {
            WelcomeMessage.Welcome();
            WelcomeMessage.Song();
            var game = new Game();
            game.Start();

           /* for (int i = 0; i < 1000; i++)
            {
                var menu = new Game();
                menu.Menu_Switch();
            }*/


        }
    }
}