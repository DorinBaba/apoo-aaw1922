using System;
using System.Collections.Generic;
using System.IO;

namespace ScriereFisierBina
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

            BinaryWriter bw = new BinaryWriter(File.Open("date.out", FileMode.Create));
            for (int i = 0; i < carti.Count; i++)
            {
                bw.Write("Datele despre carte:");
                bw.Write($"Denumire: {carti[i].Denumire}");
                bw.Write($"Autor: {carti[i].Autor}");
                bw.Write($"NumarulDePagini: {carti[i].NumarulDePagini}");
            }
            bw.Close();
        }
    }
}
