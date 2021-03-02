using System;
using System.Threading;

namespace Exemplul2
{
    class Telefon
    {
        public string AnulProducerii { get; set; }
        public int NivelBaterie { get; set; } // 0 - descarcat, 100 - full
        public void Charging()
        {
            while(NivelBaterie < 100)
            {
                NivelBaterie++;
                Console.WriteLine("Nivelul bateriei: " + NivelBaterie + "%");
                Thread.Sleep(1000);
            }
        }
    }

    class GalaxyS3 : Telefon
    {
        public new void Charging()
        {
            while (NivelBaterie < 100)
            {
                NivelBaterie+=2;
                Console.WriteLine("Nivelul bateriei: " + NivelBaterie + "%");
                Thread.Sleep(1000);
            }
        }
    }

    class GalaxyS21 : Telefon
    {
        public new void Charging()
        {
            while (NivelBaterie < 100)
            {
                NivelBaterie += 10;
                Console.WriteLine("Nivelul bateriei: " + NivelBaterie + "%");
                Thread.Sleep(500);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GalaxyS21 galaxyS21 = new GalaxyS21();
            Console.WriteLine("Incarcare galaxy S21: ");
            galaxyS21.Charging();

            GalaxyS3 galaxyS3 = new GalaxyS3();
            Console.WriteLine();
            Console.WriteLine("Incarcare galaxy S3: ");
            galaxyS3.Charging();
        }
    }
}
