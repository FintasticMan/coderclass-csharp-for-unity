using System;
using System.Collections.Generic;

namespace Oefeningen
{
    class GuessGame
    {
        static int Main(string[] args)
        {
            string secretWord = "gamertime";
            string gok;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Raad het *geheime* woord! ");
                gok = Console.ReadLine();

                if (gok == secretWord)
                {
                    Console.WriteLine("Wow, je hebt het goed!");
                    break;
                }
                else
                {
                    Console.WriteLine("Dat was niet goed... Hier is een hint! De {0}e letter van het woord is {1}", i + 1, secretWord[i]);
                }
            }
        }
    }
}