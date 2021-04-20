using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace aptecika_practica
{
    // Creati clasa Carte cu urmatoare date;
    // Denumirea, Numarul de pagini, Autor
    // Creati o lista din cel putin 2 carti si inscriti lista intr-un fisier. date.txt

    class Carte
    {
        public string Denumire { get; set; }
        public int NumarulDePagini { get; set; }
        public string Autor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Carte> carti = new List<Carte>();
            carti.Add(new Carte
            {
                Denumire = "1",
                Autor = "1",
                NumarulDePagini = 1
            });
            carti.Add(new Carte
            {
                Denumire = "2",
                Autor = "2",
                NumarulDePagini = 2
            });

            StreamWriter sr = new StreamWriter("date.txt");
            for (int i = 0; i < carti.Count; i++)
            {
                sr.WriteLine("Datele despre carte:");
                sr.WriteLine($"Denumire: {carti[i].Denumire}");
                sr.WriteLine($"Autor: {carti[i].Autor}");
                sr.WriteLine($"NumarulDePagini: {carti[i].NumarulDePagini}");
                sr.WriteLine();
            }
            sr.Close();
        }
    }
}
