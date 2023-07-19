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
            StringBuilder descriere = new StringBuilder();
            descriere.Append($"Marca: {marca}, Numar de inmatriculare: {numarInmatriculare}, capacitate cilindrica: {capacitateCilindrica}. ");
            descriere.Append($"Pasageri: ");

            if (listaPasageri.Count > 0)
            {
                foreach (var pasager in listaPasageri)
                {
                    //descriere.Append(string.Join(", ", listaPasageri));//fa-o aici cu stringbuilder
                    descriere.AppendJoin(',', pasager);
                }
            }
            else
            {
                descriere.Append("Fara pasageri ");
            }

            return descriere.ToString();
        }

        public void AdaugaPasager(string pasager)
        {
            if (!listaPasageri.Contains(pasager))
            {
                listaPasageri.Add(pasager);
            }
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
