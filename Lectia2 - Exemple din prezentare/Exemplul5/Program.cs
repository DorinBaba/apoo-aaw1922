using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplul5
{
    // Utilizarea destructorului
    class Cerc
    {
        public double raza;

        // Constructor
        public Cerc()
        {
            Console.WriteLine("Obiectul a fost creat");
        }

        // Destructor
        ~Cerc()
        {
            Console.WriteLine("Obiectul a fost distrus");
        }

        public double Diametru()
        {
            return raza * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cream obiectul cerc1
            Cerc cerc1 = new Cerc();
            cerc1.raza = 30;

            // Obiectul va fi distrus ia iesirea din metoda Main.
            // CTRL + F5 Pentru a va convinge ;) 
        }
    }
}
