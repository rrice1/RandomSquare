using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsEven(int value)
            {
                return value % 2 == 0;
            }
            Random rand = new Random();
            var myRands = new List<int> {};
            var myRands1 = new List<int> {};
            var myRands2 = new List<int> {};
            for (int i = 0; i < 20; i++)
            {
                myRands.Add(rand.Next(1,50));
                myRands1.Add(myRands[i] * myRands[i]);
            }

            foreach (var num in myRands1)
            {
                if (IsEven(num))
                {
                    myRands2.Add(num);
                }

            }
            foreach (var num in myRands2)
            {
                Console.WriteLine(num);
            }

                Console.ReadLine();
        }
    }
}
