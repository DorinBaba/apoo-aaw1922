using System;

namespace Exemplul1
{
    class Program
    {
        private static int Varsta(DateTime dataNasterii)
        {
            return (DateTime.Now - dataNasterii).Days / 365;
        }

        private static int Varsta(string dataNasterii)
        {
            // dataNasterii = "03/05/2010";
            return Varsta(DateTime.Parse(dataNasterii));
        }

        private static int Varsta(int anulNasteri)
        {
            return DateTime.Now.Year - anulNasteri;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Varsta(DateTime.Parse("03/05/2010")));
            Console.WriteLine(Varsta("03/05/2010"));
            Console.WriteLine(Varsta(2010));
        }
    }
}
