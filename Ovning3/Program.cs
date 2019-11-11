using System;

namespace Ovning3
{

    public class person
    {
        public string fornamn;
        public string efternamn;
        public float numAlder;
        public string varld;
        public string sysselsattn;

        public void skrivUt ()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Förnamn: {0}", fornamn);
            Console.WriteLine("Efternamn: {0}", efternamn);
            Console.WriteLine("Ålder: {0}", numAlder);
            Console.WriteLine("Du bor i: {0}", varld);
            Console.WriteLine("Sysselsättning: {0}", sysselsattn);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            person Person = new person();

            Console.WriteLine();
            Console.Write("Skriv in ditt förnamn: ");
            Person.fornamn = Console.ReadLine();

            Console.Write("Skriv in ditt efternamn: ");
            Person.efternamn = Console.ReadLine();

            while (Person.numAlder <= 0)
            {    
                Console.Write("Ange din ålder: ");
                string strAlder = Console.ReadLine();
            
                string s1 = "0";
                string s2 = ".";
                string s3 = ",";
                bool a = strAlder.Contains(s1);
                bool b = strAlder.Contains(s2);
                bool c = strAlder.Contains(s3);

                if (a || b || c)
                {
                    Console.WriteLine("Felaktigt format. Skriv in ett positivt heltal större än 0 för ålder!");
                }
                else
                {
                    int count = -1;
                    foreach(char character in strAlder)
                    {
                        count++;
                        if (char.IsNumber(strAlder, count))
                        {   
                            Person.numAlder = Convert.ToSingle(strAlder);
                        }
                        else
                        {
                            Console.WriteLine("Felaktigt format. Skriv in ett positivt heltal större än 0 för ålder!");
                        }
                    }
                }
            }
            Console.Write("Vart i världen bor du? ");
            Person.varld = Console.ReadLine();

            Console.Write("Vilken sysselsättning har du? ");
            Person.sysselsattn = Console.ReadLine();

            Person.skrivUt();

        }
    }
}
