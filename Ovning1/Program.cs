using System;
using System.Collections.Generic;

namespace Ovning1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            var lsDjur = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv in ett namn på ett djur: ");
                string djurNamn = Console.ReadLine();
                lsDjur.Add(djurNamn);
            }

            Console.WriteLine();

            int count = 0;
            foreach(string djur in lsDjur)
            {
                count++;
                Console.WriteLine($"Djur {count}: {djur}");
            }

        }
    }
}
