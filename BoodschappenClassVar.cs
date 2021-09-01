using System;
using System.Collections.Generic;

namespace Oefeningen
{
    class BoodschappenClassVar
    {
        Product product;
        float prijsExclBtw;
        const float btwPercentage = 21;

        static int Main(string[] args)
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
}