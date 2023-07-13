using Lab4Ex1;
using System;

namespace Lab4Ex
{
    internal class Program
    {
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
