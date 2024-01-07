using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clickerprogram
{
    internal class GetPoints : ICommando
    {
        public GetPoints(ClickerGame game)
        {
            Command = ' ';
            _Game = game;
        }
        public void Run()
        {
            _Game.points += _Game.pointsPerClick;
        }
        
        private ClickerGame _Game;
        public char Command { get; private set; }
    }
}
