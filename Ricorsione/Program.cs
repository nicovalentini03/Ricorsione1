﻿using System;
using ClassLibrary1;


namespace Ricorsione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci un numero");
            int y = int.Parse(Console.ReadLine());
            double risultato = Calcoli.mistero1(x, y);
            Console.WriteLine($"il risultato è {risultato}");
            Console.ReadLine();
        }
    }
}
