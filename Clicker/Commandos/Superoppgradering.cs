using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clickerprogram
{
    internal class Superoppgradering : ICommando
    {
        public Superoppgradering(ClickerGame game)
        {
            _Game = game;
            Command = 's';
        }
        public void Run()
        {
            if (_Game.points >= 100)
            {
                _Game.points -= 100;
                _Game.pointsPerClick += _Game.pointsPerClickIncrease;
            }

        }

        private ClickerGame _Game;
        public char Command { get; private set; }
    }
}
