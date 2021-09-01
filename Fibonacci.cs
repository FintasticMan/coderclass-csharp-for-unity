using System;
using System.Collections.Generic;

namespace Oefeningen
{
    class Fibonnacci
    {
        static int Main(string[] args)
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
}