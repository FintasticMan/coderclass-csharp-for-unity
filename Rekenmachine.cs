using System;
using System.Collections.Generic;

namespace Oefeningen
{
    class Rekenmachine
    {
        static int Main(string[] args)
        {
            Console.Write("Wat is het eerste getal waar je mee wilt rekenen? ");
            double een = Convert.ToDouble(Console.ReadLine());
            Console.Write("Wat is het tweede getal waar je mee wilt rekenen? ");
            double twee = Convert.ToDouble(Console.ReadLine());
            Console.Write("Wat wil je met deze getallen doen? ");
            char operation = Convert.ToChar(Console.ReadLine());

            double resultaat = 0d;
            switch (operation)
            {
                case '+':
                    resultaat = een + twee;
                    break;

                case '-':
                    resultaat = een - twee;
                    break;

                case 'X':
                    resultaat = een * twee;
                    break;

                case '/':
                    if (twee != 0d)
                    {
                        resultaat = een / twee;
                    }
                    break;

                default:
                    Console.WriteLine("Je hebt de operation verkeerd ingevuld, probeer nog eens");
                    break;
            }

            Console.WriteLine(resultaat);
        }
    }
}