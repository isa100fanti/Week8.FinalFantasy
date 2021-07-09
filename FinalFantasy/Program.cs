using FinalFantasy.Core.Repository;
using System;

namespace FinalFantasy
{
    class Program
    {
        static void Main(string[] args)
        {

            //IRepositoryWeapon repoW = new RepositoryWeaponM();
            //Console.WriteLine(repoW.GetWeaponsByClass("Hero"));


            Console.WriteLine("scegli dal menu cosa vuoi fare");
            bool avanti = true;
            while(avanti)
            {
                Gaming.MenuIniziale();
            }
        }
    }
}
