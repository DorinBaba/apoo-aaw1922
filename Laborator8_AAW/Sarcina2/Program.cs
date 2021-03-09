using System;

namespace Sarcina2
{

    class Punct
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Punct operator +(Punct p1, Punct p2)
        {
            // p1 = (5, 5), p2 = (2, 10), rezultat = p1 + p2 = (7, 15)
            return new Punct
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }

        public static Punct operator -(Punct p1, Punct p2)
        {
            // p1 = (5, 5), p2 = (2, 10), rezultat = p1 - p2 = (3, -5)
            return new Punct
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
        }

        public static Punct operator *(Punct p1, Punct p2)
        {
            // p1 = (5, 5), p2 = (2, 10), rezultat = p1 * p2 = (10, 50)
            return new Punct
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
        }

        public static Punct operator /(Punct p1, Punct p2)
        {
            // p1 = (5, 5), p2 = (2, 10), rezultat = p1 / p2 = (2.5, 0.5)
            return new Punct
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
        }

        public static bool operator ==(Punct p1, Punct p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Punct p1, Punct p2)
        {
            return p1.X != p2.X && p1.Y != p2.Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Punct p1 = new Punct
            {
                X = 5,
                Y = 5
            };

            Punct p2 = new Punct
            {
                X = 2,
                Y = 10
            };

            Console.WriteLine($"{p1} + {p2} = {p1 + p2}"); 
            Console.WriteLine($"{p1} - {p2} = {p1 - p2}"); 
            Console.WriteLine($"{p1} * {p2} = {p1 * p2}"); 
            Console.WriteLine($"{p1} / {p2} = {p1 / p2}"); 
        }
    }
}
