using System;

namespace FinalFantasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scegli dal menu cosa vuoi fare");
            bool avanti = true;
            while(avanti)
            {
                Gaming.MenuIniziale();
            }
        }
    }
}
