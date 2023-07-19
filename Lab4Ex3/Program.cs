using System;
using System.Collections.Generic;

namespace Lab4Ex3
{
    internal class Program
    {
        /*Autoturismului ii putem adauga pasageri sub forma unor siruri de caractere*/
        static void Main(string[] args)
        {     
            Autoturism vehiculFaraLimita = new Autoturism("VW", "SB12CCC", 2000);
            vehiculFaraLimita.AdaugaPasager("Ion");
            vehiculFaraLimita.AdaugaPasager("Costel");
            vehiculFaraLimita.AdaugaPasager("Irina");

            Console.WriteLine(vehiculFaraLimita.GetDescription());

            Console.WriteLine(vehiculFaraLimita.EstePasager("Ion"));

            vehiculFaraLimita.StergePasager("Ion");

            Console.WriteLine(vehiculFaraLimita.EstePasager("Ion"));

            Console.WriteLine(vehiculFaraLimita.GetDescription());
        }
    }
}
