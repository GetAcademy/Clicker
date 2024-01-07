namespace Clickerprogram
{
    internal class ClickerGame
    {
        public int points = 0;
        public int pointsPerClick = 1;
        public int pointsPerClickIncrease = 1;

        public void Game()
        {

            while (true)
            {

                Console.WriteLine($"Du har {points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                char command = Console.ReadKey().KeyChar;
                if (command == 'x') Environment.Exit(0);
                else if (command == ' ') points += pointsPerClick;
                else if (command == 'k' && points >= 10)
                {
                    points -= 10;
                    pointsPerClick += pointsPerClickIncrease;
                }
                else if (command == 's' && points >= 100)
                {
                    points -= 100;
                    pointsPerClickIncrease++;
                }
            }
        }

    }
}
