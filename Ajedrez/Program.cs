﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero();
            tablero.PintaTablero();


            Console.Read();
        }
    }
}
