using System;
using System.Collections.Generic;

namespace MedieDeConcurs
{
    class Imagine
    {
        public string path;
        public int dimensiuneX;
        public int dimensiuneY;
    }

    class Automibil999
    {
        public string tip;
        public string Nume;

        public List<Imagine> imagini;

        public string descriere;

        public string Model;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Automibil999 automobil = new Automibil999();
            automobil.tip = "Automobil";
            automobil.Nume = "BMW 5 Series";
            automobil.descriere = "In stare buna";


            Console.WriteLine(automobil.tip);
            Console.WriteLine(automobil.Nume);
            Console.WriteLine(automobil.descriere);
        }
    }
}
