﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clickerprogram
{
    internal class Disrupt : ICommando
    {
        public Disrupt()
        {
            Command = "x";
            
        }
        public void Run()
        {
            
        }


        public string Command { get; }
    }
}
