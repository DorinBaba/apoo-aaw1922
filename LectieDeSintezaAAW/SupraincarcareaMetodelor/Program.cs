using System;
using System.Linq.Expressions;

namespace SupraincarcareaMetodelor
{
    class Elev
    {
        public string Nume { get; set; }
        public double Media { get; set; }

        /// <summary>
        /// Returneaza media * 100
        /// </summary>
        /// <returns></returns>
        public double Bursa()
        {
            if (Media < 8)
                return 0;

            return Media * 100;
        }

        /// <summary>
        /// Returneaza media * 100 + bonus
        /// </summary>
        /// <param name="bonus"></param>
        /// <returns></returns>
        public double Bursa(double bonus)
        {
            if (Media < 8)
                return 0;

            return Media * 100 + bonus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Elev e1 = new Elev();
            e1.Media = 10;
            Console.WriteLine($"Bursa() - {e1.Bursa()}");
            Console.WriteLine($"Bursa(150) - {e1.Bursa(150)}");
        }
    }
}
