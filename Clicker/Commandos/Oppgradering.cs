
namespace Clickerprogram
{
    internal class Oppgradering : ICommando
    {
        public Oppgradering(ClickerGame game)
        {
            Command = 'k';
            _Game = game;
        }
        public void Run()
        {
            if (_Game.points >= 10)
            {
                _Game.points -= 10;
                _Game.pointsPerClick++;
            }
        }

        private ClickerGame _Game;
        public char Command { get; }
    }
}
