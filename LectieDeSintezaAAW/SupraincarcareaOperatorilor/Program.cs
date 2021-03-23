using System;

namespace SupraincarcareaOperatorilor
{
    class Punct
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Punct operator +(Punct p1, Punct p2)
        {
            return new Punct
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punct punct1 = new Punct
            {
                X = 4,
                Y = 10
            };

            Punct punct2 = new Punct
            {
                X = 5,
                Y = 1
            };

            Punct rezultat = punct1 + punct2;        
        }
    }
}
