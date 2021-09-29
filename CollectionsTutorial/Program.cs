using System;
using System.Collections.Generic;

namespace CollectionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var number = rnd.Next(0, 31);
            var BowlingScore = new List<int>();
            for(int idx = 1; idx <= 30; idx++)
            {
                BowlingScore.Add(number);
            }
            var totalscore = 0;
            foreach(var idx in BowlingScore)
            {
                totalscore += idx;
            }
            Console.WriteLine($"Your score is {totalscore}");
            //var ListOfNumbers = new List<int>();
            //ListOfNumbers.Add(56);
            //ListOfNumbers.Add(13);
            //ListOfNumbers.Add(72);
            //ListOfNumbers.Add(42);
            //ListOfNumbers.Add(44);
            //ListOfNumbers.Add(98);
            //ListOfNumbers.Add(7);

            //var sum = 0;
            //foreach(var nbr in ListOfNumbers)
            //{
            //    sum += nbr;
            //}
            //Console.WriteLine($"Sum is {sum}");
        }
    }
}
