﻿using System;

namespace programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(100);

            bool Vinna = false;
            while (Vinna == false)
            {

                int tal;

                Console.WriteLine("gissa ett tal mellan 1 och 100");
                tal = Convert.ToInt32(Console.ReadLine());


                if (tal == slump_tal)
                {
                    Vinna = true;
                    Console.WriteLine("talet är rätt grattis");
                }

                else if (tal > slump_tal)
                {
                    Console.WriteLine("talet är för högt");
                }
                else if (tal < slump_tal)
                {
                    Console.WriteLine("talet är för lågt");
                }
            }
        }     
    }
}
