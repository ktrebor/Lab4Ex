using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Ex3
{
    class Autoturism
    {
        private string marca = string.Empty;
        private string numarInmatriculare = string.Empty;
        private readonly int capacitateCilindrica;
        private List<string> listaPasageri = new List<string>();

        public Autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarInmatriculare = numarInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        public string GetDescription()
        {
            string mesajPasager = string.Empty;

            if (listaPasageri.Count > 0)
            {
                foreach (var pasager in listaPasageri)
                {
                    mesajPasager = string.Join(", ", listaPasageri);
                }
            } 
            else
            {
                mesajPasager = "Fara pasageri ";
            }

            string descriere = $"Marca: {marca}, Numar de inmatriculare: {numarInmatriculare}, capacitate cilindrica: {capacitateCilindrica}. Pasageri: {mesajPasager}, ";

            return descriere;
        }

        public void AdaugaPasager(string pasager)
        {
            listaPasageri.Add(pasager);
        }

        public void StergePasager(string pasager)
        {
            listaPasageri.Remove(pasager);
        }

        public bool EstePasager(string pasager)
        {
            return listaPasageri.Contains(pasager);
        }
    }
}
