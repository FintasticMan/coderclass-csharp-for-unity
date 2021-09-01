using System;
using System.Collections.Generic;

namespace Oefeningen
{
    class FavGame
    {
        static int Main(string[] args)
        {
            Console.Write("Wat is jouw favoriete computerspel? ");
            string game = Console.ReadLine();
            Console.WriteLine("Jouw favoriete computerspel is " + game);
        }
    }
}