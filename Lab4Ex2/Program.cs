using System;

namespace Lab4Ex2
{
    internal class Program
    {
/*Scrieti un program care va modela un autoturism . Un autoturism va avea o marca ( string), un numar de inmatriculare ( string), precum si o capacitate cilindrica ( int).
Autoturismul va avea
---Campurile corespunzatoare caracteristicilor autoturismului
---Un constructor care va initializa campurile acestuia
---O metoda GetDescription ” care va returna descrierea acestuia sub forma : “ marca, numarDeInmatriculare, capacitateCilindrica

Folositi: clase , campuri , metode , modificatorii de acces adecvati , comentarii xml pentru metodele publice
Creeati doua obiecte de tipul autoturism in functia “Main” apelati le metodele si afisati rezultatul
        */
        static void Main(string[] args)
        {
            Autoturism vehiculPersonal = new Autoturism("Mazda", "SB12AAA", 1599);

            vehiculPersonal.GetDescription();

            Autoturism vehiculServiciu = new Autoturism("Skoda", "SB22BBB", 1002);

            vehiculServiciu.GetDescription();
        }
    }
}
