using System;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 1, s2 = 1;

            while (s1 <= 20)
            {
                while (s2 <= 10)
                {
                    Console.WriteLine($"{s1}*{s2}={s1 * s2}");
                    s2++;
                }
                s1++;
                s2 = 1;
                Console.WriteLine("_________\n");

            }

        }
    }
}
