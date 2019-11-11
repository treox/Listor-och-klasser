using System;

namespace Ovning2
{

    class Hund
    {
        private string namn;
        private int alder;

        public Hund(string namnToSet, int alderToSet)
        {
            namn = namnToSet;
            alder = alderToSet;
        }

        public void Talk()
        {
            Console.WriteLine($"{namn}, {alder} säger: \"dogsound\"");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            Hund testHund1 = new Hund("testNamn1", 2);
            testHund1.Talk();

            Hund testHund2 = new Hund("testNamn2", 3);
            testHund2.Talk();

        }
    }
}
