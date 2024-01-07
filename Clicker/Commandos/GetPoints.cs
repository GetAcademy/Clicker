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
            Command = " ";
            _Game = game;
        }
        public void Run()
        {
            
        }
        
        private ClickerGame _Game;
        public string Command { get; private set; }
    }
}
