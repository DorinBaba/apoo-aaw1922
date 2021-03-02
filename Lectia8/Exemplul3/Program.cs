using System;

namespace Exemplul3
{
    class Fractie
    {
        public int Numarator { get; set; }
        public int Numitor { get; set; }

        public static Fractie operator +(Fractie f1, Fractie f2)
        {
            return new Fractie
            {
                Numarator = f1.Numarator * f2.Numitor + f2.Numarator * f1.Numitor,
                Numitor = f1.Numitor * f2.Numitor
            };
        }

        public static Fractie operator -(Fractie f1, Fractie f2)
        {
            return new Fractie
            {
                Numarator = f1.Numarator * f2.Numitor - f2.Numarator * f1.Numitor,
                Numitor = f1.Numitor * f2.Numitor
            };
        }

        public static Fractie operator *(Fractie f1, Fractie f2)
        {
            return new Fractie
            {
                Numarator = f1.Numarator * f2.Numarator,
                Numitor = f1.Numitor * f2.Numitor
            };
        }

        public static Fractie operator /(Fractie f1, Fractie f2)
        {
            return f1 * (new Fractie { Numarator = f2.Numitor, Numitor = f2.Numarator });
        }

        public static Fractie operator ++(Fractie f)
        {
            return new Fractie
            {
                Numarator = f.Numarator + f.Numitor,
                Numitor = f.Numitor
            };
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Fractie fractie1 = new Fractie();
            fractie1.Numarator = 4;
            fractie1.Numitor = 7;

            Fractie fractie2 = new Fractie();
            fractie2.Numarator = 2;
            fractie2.Numitor = 5;

            Fractie rezultat = fractie1 + fractie2;
            Console.WriteLine("Adunare");
            Console.WriteLine(rezultat.Numarator + "/" + rezultat.Numitor);

            rezultat = fractie1 - fractie2;
            Console.WriteLine("Scadere");
            Console.WriteLine(rezultat.Numarator + "/" + rezultat.Numitor);

            rezultat = fractie1 * fractie2;
            Console.WriteLine("Inmultire");
            Console.WriteLine(rezultat.Numarator + "/" + rezultat.Numitor);

            rezultat = fractie1 / fractie2;
            Console.WriteLine("Impartire");
            Console.WriteLine(rezultat.Numarator + "/" + rezultat.Numitor);

            rezultat = ++fractie1;
            Console.WriteLine("Incrementare");
            Console.WriteLine(rezultat.Numarator + "/" + rezultat.Numitor);

            // Operatori binari: +, -, *, /
            // Operatori unari: ++, --
        }
    }
}
