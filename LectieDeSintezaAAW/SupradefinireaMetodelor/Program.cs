using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace SupradefinireaMetodelor
{

    class Persoana
    {
        public string Nume { get; set; }
        public void Afisare() => Console.WriteLine(Nume);
    }


    class Angajat : Persoana
    {
        public double Salariu { get; set; }
        public new void Afisare()
        {
            base.Afisare();
            Console.WriteLine(Salariu);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persoana p = new Persoana();
            p.Nume = "Lil pump";
            Console.WriteLine("Afisare persoana:");
            p.Afisare();

            Console.WriteLine();

            Angajat a = new Angajat();
            a.Nume = "Lil pip";
            a.Salariu = 2000;
            Console.WriteLine("Afisare angajat");
            a.Afisare();
        }
    }
}
