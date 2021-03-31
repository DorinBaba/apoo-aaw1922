using System;
using System.Collections.Generic;
using System.Threading;

namespace Sarcina2
{
    interface IVehicul
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnulProducerii { get; set; }

        public void Porneste();
        public void Opreste();
        public void Deplaseaza();
    }

    interface ISistemAudio
    {
        public string ModelSistemAudio { get; set; }

        public void Canta();
    }

    interface INavigatie
    {
        public string ModelGPS { get; set; }

        public void Localizeaza();
    }

    class Automobil : IVehicul, ISistemAudio, INavigatie
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnulProducerii { get; set; }
        public string ModelSistemAudio { get; set; }
        public string ModelGPS { get; set; }

        public void Porneste()
        {
            Console.WriteLine("Automobilul a fost pornit");
        }

        public void Opreste()
        {
            Console.WriteLine("Automobilul a fost oprit");
        }

        public void Deplaseaza()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Automobilul de deplaseaza...");
                Thread.Sleep(500);
            }
        }

        public void Localizeaza()
        {
            Random random = new Random();
            int x = random.Next(0, 100000);
            int y = random.Next(0, 100000);

            Console.WriteLine($"Coordonatele: ({x}, {y})");
        }

        public void Canta()
        {
            List<string> melodii = new List<string>
            {
                "guci gang guci gang",
                "spotlight moonlight",
                "lasciatemi cantare"
            };

            int index = (new Random()).Next(0, 3);
            Console.WriteLine(melodii[index]);
        }
    }

    class Telefon: INavigatie
    {
        public string ModelGPS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Localizeaza()
        {
            Random random = new Random();
            int x = random.Next(0, 100000);
            int y = random.Next(0, 100000);

            Console.WriteLine($"Coordonatele: ({x}, {y})");
        }
    }

    class FBI
    {
        public void LocalizeazaInfractorul(INavigatie dispozitiv)
        {
            Console.WriteLine("Infractorul se afla in pozitia geografica:");
            dispozitiv.Localizeaza();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobil automobil = new Automobil
            {
                Marca = "Audi",
                Model = "A5",
                AnulProducerii = 2018,
                ModelGPS = "Garmin",
                ModelSistemAudio = "Bose"
            };

            var telefon = new Telefon();
            var FBI = new FBI();

            FBI.LocalizeazaInfractorul(automobil);
            FBI.LocalizeazaInfractorul(telefon);
        }
    }
}
