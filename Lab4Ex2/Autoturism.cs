using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Ex2
{
    class Autoturism
    {
        private string marca = string.Empty;
        private string numarInmatriculare = string.Empty;
        private readonly int capacitateCilindrica;

        public Autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarInmatriculare = numarInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        public void GetDescription()
        {
            Console.WriteLine($"{marca}, {numarInmatriculare}, {capacitateCilindrica}");
        }
    }
}
