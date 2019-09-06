using System;

namespace programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal;
            Console.Write("ange ett heltal: ");
            tal = Convert.ToInt32(Console.ReadLine());
            if (tal % 2 == 0)
                Console.WriteLine("talet är jämnt");
            else
                Console.WriteLine("talet är udda");

        }
    }
}
