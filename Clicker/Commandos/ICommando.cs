using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clickerprogram
{
    internal interface ICommando
    {
        void Run();
        public char Command { get; }
    }
}
