
namespace Clickerprogram
{
    internal class Oppgradering : ICommando
    {
        public Oppgradering(ClickerGame game)
        {
            Command = "k";
            _Game = game;
        }
        public void Run()
        {
            
        }

        private ClickerGame _Game;
        public string Command { get; }
    }
}
