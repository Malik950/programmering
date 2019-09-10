using System;

namespace programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 100);

            int tal;

            Console.WriteLine("gissa ett tal mellan 1 och 100");
            tal = Convert.ToInt32(Console.ReadLine());
            
           
            if (tal == slump_tal)
                Console.WriteLine("talet är rätt grattis");
            else
                Console.WriteLine("talet är fel");

        }
    }
}
