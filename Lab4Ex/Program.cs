using Lab4Ex1;
using System;

namespace Lab4Ex
{
    internal class Program
    {
/*Un dulap are trei caracteristici : lungime , latime , inaltime . Dulapul va avea ommetoda care va calcula volumul acestuia .

Folositi o clasa care va modela un dulap .
---Clasa va avea trei campuri private intregi : lungime , latime , inaltime
---Cele trei campuri vor fi initializate cu ajutorul constructorului
---Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri

Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si afisati rezultatul
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu masurile unui dulap");
            Console.Write("Lungime: ");
            double lungime = Convert.ToDouble(Console.ReadLine());
            Console.Write("Latime: ");
            double latime = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inaltime: ");
            double inaltime = Convert.ToDouble(Console.ReadLine());

            Dulap bucatarie = new Dulap(lungime, latime, inaltime);
            
            Console.WriteLine($"Volumul este {bucatarie.GetVolum()}");
        }
    }
}
