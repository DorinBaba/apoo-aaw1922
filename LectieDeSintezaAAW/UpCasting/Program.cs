using System;
using System.Collections.Generic;

namespace UpCasting
{
    class Persoana
    {
        public string Nume { get; set; }
        public virtual void Afisare() => Console.WriteLine(Nume);
    }

    class Elev: Persoana
    {
        public double Media { get; set; }

        public override void Afisare()
        {
            base.Afisare();
            Console.WriteLine(Media);
        }
    }

    class Profesor: Persoana
    {
        public string Catedra { get; set; }
        public override void Afisare()
        {
            base.Afisare();
            Console.WriteLine(Catedra);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Persoana> persoane = new List<Persoana>();
            persoane.Add(new Elev { Nume = "Vin Diesel", Media = 9.20 });
            persoane.Add(new Profesor { Nume = "Paul Walker", Catedra = "Informatica" });

            foreach (var item in persoane)
            {
                item.Afisare();
                Console.WriteLine();
            }

            List<object> lista = new List<object>();

            lista.Add(1);
            lista.Add(2.5);
            lista.Add("Salut");
            lista.Add(new Elev { Nume = "Vin Diesel", Media = 9.20 });
        }
    }
}
