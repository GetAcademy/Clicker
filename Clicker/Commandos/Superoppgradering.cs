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
            Command = "s";
        }
        public void Run()
        {
            
        }

        private ClickerGame _Game;
        public string Command { get; private set; }
    }
}
