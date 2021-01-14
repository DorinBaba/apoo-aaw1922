using System;
using System.Collections.Generic;

namespace Sarcina1
{
    class Angajat
    {
        public string nume;
        public string functia;
        public int anulAngajarii;
        public int oreLucrate;
        public double plataPerOra;

        public void Citire()
        {
            Console.Write("Nume:");
            nume = Console.ReadLine();

            Console.Write("Functia:");
            functia = Console.ReadLine();

            Console.Write("Anul angajarii:");
            anulAngajarii = int.Parse(Console.ReadLine());

            Console.Write("Ore lucrate:");
            oreLucrate = int.Parse(Console.ReadLine());

            Console.Write("Plata per ora:");
            plataPerOra = double.Parse(Console.ReadLine());
        }

        public void Afisare()
        {
            Console.WriteLine($"Nume: {nume}");
            Console.WriteLine($"Functia: {functia}");
            Console.WriteLine($"Anul angajarii: {anulAngajarii}");
            Console.WriteLine($"Ore lucrate: {oreLucrate}");
            Console.WriteLine($"Plata per ora: {plataPerOra}");
            Console.WriteLine($"Salariu Calculat: {SalariuCalculat()}");
            Console.WriteLine($"Spor: {Spor()}");
            Console.WriteLine($"Salariu Primit: {SalariuPrimit()}");
        }

        public int Stagiu() => DateTime.Now.Year - anulAngajarii;

        public double SalariuCalculat() => oreLucrate * plataPerOra;

        public double Spor() => SalariuCalculat() / 100 * 15;

        public double SalariuPrimit() => SalariuCalculat() + Spor();
    }


    class Program
    {
        static void Main(string[] args)
        {
            int nrAngajati = int.Parse(Console.ReadLine());

            List<Angajat> angajati = new List<Angajat>();

            for (int i = 0; i < nrAngajati; i++)
            {
                // Cream un obiect de tip angajat
                Angajat newAngajat = new Angajat();

                // Citirea datelor despre angajat.
                Console.WriteLine();
                Console.WriteLine("Cititi datele despre angajatul " + (i+1));
                newAngajat.Citire();

                angajati.Add(newAngajat);
            }

            for (int i = 0; i < nrAngajati; i++)
            {
                 angajati[i].Afisare();
            }
        }
    }
}
