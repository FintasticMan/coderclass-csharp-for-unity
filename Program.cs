using System;
using System.Collections.Generic;

namespace Oefeningen
{
    class Program
    {
        static int Main(string[] args)
        {
            new FavGame();
            Console.WriteLine("");
            new Boodschappen();
            Console.WriteLine("");
            new Rekenmachine();
            Console.WriteLine("");
            new GuessGame();
            Console.WriteLine("");
            new Fibonacci();
            Console.WriteLine("");
            new BoodschappenExtBtw();
            Console.WriteLine("");
            new BoodschappenClassVar();
            Console.WriteLine("");
            new MobielProgramma();

            return 0;
        }
    }

    class FavGame
    {
        public FavGame()
        {
            Console.Write("Wat is jouw favoriete computerspel? ");
            string game = Console.ReadLine();
            Console.WriteLine("Jouw favoriete computerspel is " + game);
        }
    }

    class Boodschappen
    {
        public Boodschappen()
        {
            const float btw = 21f;

            Console.WriteLine("De volgende dingen zijn te koop:");
            List<Product> producten = new List<Product>()
            {
                new Product("product1", 2.70f),
                new Product("product2", 14.50f),
                new Product("product3", 3.99f),
                new Product("product4", 6.50f),
                new Product("product5", 100f),
                new Product("product6", 0.99f),
                new Product("product7", 29.50f),
                new Product("product8", 88f),
                new Product("product9", 102f),
                new Product("product10", 450f)
            };

            for (int i = 0; i < producten.Count; i++)
            {
                Console.WriteLine("{0}. {1}  EUR{2}", i + 1, producten[i].naam, producten[i].prijs);
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write("\nWelke van die wil je kopen? ");
                    int productNr = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Hoeveel van die wil je kopen? ");
                    producten[productNr].aantal += Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ongeldige invoer getoond");
                }
            }

            List<float> bedragen = new List<float>();
            float totAantal = 0;
            float subtotaal = 0;

            Console.WriteLine("AANTAL       OMSCHRIJVING        PRIJS       BEDRAG");
            Console.WriteLine("---------------------------------------------------");

            for (int i = 0; i < producten.Count; i++)
            {
                bedragen.Add(producten[i].prijs * producten[i].aantal);
                totAantal += producten[i].aantal;
                subtotaal += bedragen[i];

                if (producten[i].aantal != 0)
                {
                    Console.WriteLine("{0}          {1}                 EUR{2}      EUR{3}", producten[i].aantal, producten[i].naam, Math.Round((Decimal)producten[i].prijs, 2, MidpointRounding.AwayFromZero), Math.Round((Decimal)bedragen[i], 2, MidpointRounding.AwayFromZero));
                }
            }

            float totaal = subtotaal * (btw / 100 + 1);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("{0}          SUBTOTAAL                       EUR{1}", Math.Round((Decimal)totAantal, 2, MidpointRounding.AwayFromZero), Math.Round((Decimal)subtotaal, 2, MidpointRounding.AwayFromZero));
            Console.WriteLine("BTW  {0}%                            TOTAAL  EUR{1}", btw, Math.Round((Decimal)totaal, 2, MidpointRounding.AwayFromZero));
        }
    }

    class Product
    {
        public string naam;
        public float prijs;
        public int aantal;

        public Product(string argNaam, float argPrijs)
        {
            naam = argNaam;
            prijs = argPrijs;
            aantal = 0;
        }
    }

    class Rekenmachine
    {
        public Rekenmachine()
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

    class GuessGame
    {
        public GuessGame()
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

    class Fibonacci
    {
        public Fibonacci()
        {
            double prevNum = 0;
            double currentNum = 1;
            double nextNum;

            Console.WriteLine(currentNum);

            for (int i = 0; i < 19; i++)
            {
                nextNum = currentNum + prevNum;
                prevNum = currentNum;
                currentNum = nextNum;

                Console.WriteLine(currentNum);
            }
        }
    }

    class BoodschappenExtBtw
    {
        public BoodschappenExtBtw()
        {
            const float btw = 21f;

            Console.WriteLine("De volgende dingen zijn te koop:");
            List<Product> producten = new List<Product>()
            {
                new Product("product1", 2.70f),
                new Product("product2", 14.50f),
                new Product("product3", 3.99f),
                new Product("product4", 6.50f),
                new Product("product5", 100f),
                new Product("product6", 0.99f),
                new Product("product7", 29.50f),
                new Product("product8", 88f),
                new Product("product9", 102f),
                new Product("product10", 450f)
            };

            for (int i = 0; i < producten.Count; i++)
            {
                Console.WriteLine("{0}. {1}  EUR{2}", i + 1, producten[i].naam, producten[i].prijs);
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write("\nWelke van die wil je kopen? ");
                    int productNr = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Hoeveel van die wil je kopen? ");
                    producten[productNr].aantal += Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ongeldige invoer getoond");
                }
            }

            List<float> bedragen = new List<float>();
            float totAantal = 0;
            float subtotaal = 0;
            float totaal = 0;

            Console.WriteLine("AANTAL       OMSCHRIJVING        PRIJS       BEDRAG");
            Console.WriteLine("---------------------------------------------------");

            for (int i = 0; i < producten.Count; i++)
            {
                bedragen.Add(producten[i].prijs * producten[i].aantal);
                totAantal += producten[i].aantal;
                subtotaal += bedragen[i];
                totaal += Btw(producten[i].aantal, producten[i].prijs, btw);

                if (producten[i].aantal != 0)
                {
                    Console.WriteLine("{0}          {1}                 EUR{2}      EUR{3}", producten[i].aantal, producten[i].naam, Math.Round((Decimal)producten[i].prijs, 2, MidpointRounding.AwayFromZero), Math.Round((Decimal)bedragen[i], 2, MidpointRounding.AwayFromZero));
                }
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("{0}          SUBTOTAAL                       EUR{1}", Math.Round((Decimal)totAantal, 2, MidpointRounding.AwayFromZero), Math.Round((Decimal)subtotaal, 2, MidpointRounding.AwayFromZero));
            Console.WriteLine("BTW  {0}%                            TOTAAL  EUR{1}", btw, Math.Round((Decimal)totaal, 2, MidpointRounding.AwayFromZero));
        }

        private float Btw(int aantal, float prijsExclBtw, float btw)
        {
            return prijsExclBtw * aantal * (btw / 100 + 1);
        }
    }

    class BoodschappenClassVar
    {
        Product product;
        float prijsExclBtw;
        const float btwPercentage = 21;

        public BoodschappenClassVar()
        {
            Console.WriteLine("De volgende dingen zijn te koop:");
            List<Product> producten = new List<Product>()
            {
                new Product("product1", 2.70f),
                new Product("product2", 14.50f),
                new Product("product3", 3.99f),
                new Product("product4", 6.50f),
                new Product("product5", 100f),
                new Product("product6", 0.99f),
                new Product("product7", 29.50f),
                new Product("product8", 88f),
                new Product("product9", 102f),
                new Product("product10", 450f)
            };

            for (int i = 0; i < producten.Count; i++)
            {
                Console.WriteLine("{0}. {1}  EUR{2}", i + 1, producten[i].naam, producten[i].prijs);
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write("\nWelke van die wil je kopen? ");
                    int productNr = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Hoeveel van die wil je kopen? ");
                    producten[productNr].aantal += Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ongeldige invoer getoond");
                }
            }

            List<float> bedragen = new List<float>();
            float totAantal = 0;
            float subtotaal = 0;
            float totaal = 0;

            Console.WriteLine("AANTAL       OMSCHRIJVING        PRIJS       BEDRAG");
            Console.WriteLine("---------------------------------------------------");

            for (int i = 0; i < producten.Count; i++)
            {
                bedragen.Add(producten[i].prijs * producten[i].aantal);
                totAantal += producten[i].aantal;
                subtotaal += bedragen[i];
                product = producten[i];
                prijsExclBtw = product.prijs;
                totaal += Btw();

                if (producten[i].aantal != 0)
                {
                    Console.WriteLine("{0}          {1}                 EUR{2}      EUR{3}", producten[i].aantal, producten[i].naam, Math.Round((Decimal)producten[i].prijs, 2, MidpointRounding.AwayFromZero), Math.Round((Decimal)bedragen[i], 2, MidpointRounding.AwayFromZero));
                }
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("{0}          SUBTOTAAL                       EUR{1}", Math.Round((Decimal)totAantal, 2, MidpointRounding.AwayFromZero), Math.Round((Decimal)subtotaal, 2, MidpointRounding.AwayFromZero));
            Console.WriteLine("BTW  {0}%                            TOTAAL  EUR{1}", btwPercentage, Math.Round((Decimal)totaal, 2, MidpointRounding.AwayFromZero));
        }

        private float Btw()
        {
            return prijsExclBtw * product.aantal * (btwPercentage / 100 + 1);
        }
    }

    class MobielProgramma
    {
        public MobielProgramma()
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
