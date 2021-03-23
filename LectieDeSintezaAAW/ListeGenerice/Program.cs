using System;
using System.Collections.Generic;

namespace ListeGenerice
{

    class Elev
    {
        public string Nume { get; set; }
        public double Media { get; set; }

        public Elev(string nume, double media)
        {
            Nume = nume;
            Media = media;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Elev> elevi = new List<Elev>();

            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));
            elevi.Add(new Elev("Johnson Statham", 6.34));

            foreach (var item in elevi)
            {
                Console.WriteLine(item.Nume);
            }
        }
    }
}
