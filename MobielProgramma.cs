using System;
using System.Collections.Generic;

namespace Oefeningen
{
    class MobielProgramma
    {
        static int Main(string[] args)
        {
            Mobiel mobiel1 = new Mobiel("Apple", "iPhone XS", "iOS");
            Mobiel mobiel2 = new Mobiel("Samsung", "Galaxy S7", "Android");
            Mobiel mobiel3 = new Mobiel("Google", "Pixel 3", "'Chrome OS'");

            Console.WriteLine("De oprichter van {0} is {1}", mobiel1.type, mobiel1.Oprichter());
            Console.WriteLine("De oprichter van {0} is {1}", mobiel2.type, mobiel2.Oprichter());
            Console.WriteLine("De oprichter van {0} is {1}", mobiel3.type, mobiel3.Oprichter());

            Console.WriteLine("\nDe telefoons die we hebben zijn:");
            Console.WriteLine("1. {0} {1}", mobiel1.type, mobiel1.model);
            Console.WriteLine("2. {0} {1}", mobiel2.type, mobiel2.model);
            Console.WriteLine("3. {0} {1}", mobiel3.type, mobiel3.model);

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            bool doorgaan = true;
            int keuze;
            int aantal;
            while (doorgaan)
            {
                Console.Write("Welke wil je kiezen? ");
                keuze = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hoeveel wil je daarvan hebben? ");
                aantal = Convert.ToInt32(Console.ReadLine());

                switch (keuze)
                {
                    case 1:
                        count1 += aantal;
                        break;
                    case 2:
                        count2 += aantal;
                        break;
                    case 3:
                        count3 += aantal;
                        break;
                    default:
                        Console.WriteLine("De telefoon die je het gekozen hebben wij niet, probeer nog eens.");
                        break;
                }

                Console.Write("Wil je nog een telefoon kopen? [y/n] ");
                if (Console.ReadLine() != "y")
                {
                    doorgaan = false;
                }
            }

            float bedrag1 = mobiel1.prijs * count1;
            float bedrag2 = mobiel2.prijs * count2;
            float bedrag3 = mobiel3.prijs * count3;
            float subtotaal = bedrag1 + bedrag2 + bedrag3;
            float totaal = subtotaal * (Mobiel.btw / 100 + 1);
            float verzendkosten = 0f;

            if (subtotaal < 1500f)
            {
                if (count1 != 0)
                {
                    verzendkosten += mobiel1.verzendkosten;
                }
                else if (count2 != 0)
                {
                    verzendkosten += mobiel2.verzendkosten;
                }
                else if (count3 != 0)
                {
                    verzendkosten += mobiel3.verzendkosten;
                }
            }

            totaal += verzendkosten;

            Console.WriteLine("AANTAL       OMSCHRIJVING        PRIJS       BEDRAG");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("{0}          {1} {2}             EUR{3}      EUR{4}", count1, mobiel1.type, mobiel1.model, mobiel1.prijs, bedrag1);
            Console.WriteLine("{0}          {1} {2}             EUR{3}      EUR{4}", count2, mobiel2.type, mobiel2.model, mobiel2.prijs, bedrag2);
            Console.WriteLine("{0}          {1} {2}             EUR{3}      EUR{4}", count3, mobiel3.type, mobiel3.model, mobiel3.prijs, bedrag3);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("{0}          SUBTOTAAL                       EUR{1}", count1 + count2 + count3, subtotaal);
            Console.WriteLine("BTW  {0}%    VERZENDKOSTEN   EUR{1}  TOTAAL  EUR{2}", Mobiel.btw, verzendkosten, totaal);
        }
    }

    class Mobiel
    {
        public string type;
        public string model;
        public string os;
        public float prijs;
        public float verzendkosten;

        public static float btw = 21f;

        public Mobiel(string argType, string argModel, string argOS)
        {
            type = argType;
            model = argModel;
            os = argOS;

            switch (model)
            {
                case "iPhone XS":
                    prijs = 429f;
                    verzendkosten = 50f;
                    break;
                case "Galaxy S7":
                    prijs = 300f;
                    verzendkosten = 26f;
                    break;
                case "Pixel 3":
                    prijs = 469.99f;
                    verzendkosten = 30f;
                    break;
            }
        }

        public string Oprichter()
        {
            string oprichter;

            switch (type)
            {
                case "Apple":
                    oprichter = "Steve Jobs";
                    break;
                case "Samsung":
                    oprichter = "Lee Byung-chul";
                    break;
                case "Google":
                    oprichter = "Larry Page & Sergey Brin";
                    break;
                default:
                    oprichter = "unknown";
                    break;
            }

            return oprichter;
        }
    }
}