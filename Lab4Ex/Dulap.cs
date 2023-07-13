using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Ex1
{
    internal class Dulap
    {
        private readonly double lungime;
        private readonly double latime;
        private readonly double inaltime;
        
        public Dulap(double lungime, double latime, double inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public double GetVolum()
        {
            return lungime * latime * inaltime;
        }
    }
}
