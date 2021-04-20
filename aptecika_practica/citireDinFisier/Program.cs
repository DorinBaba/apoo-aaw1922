using System;
using System.Collections.Generic;
using System.IO;

namespace citireDinFisier
{
    class Carte
    {
        public string Denumire { get; set; }
        public int NumarulDePagini { get; set; }
        public string Autor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Carte> carti = new List<Carte>();
            StreamReader sr = new StreamReader("date.txt");
            for (int i = 0; i < 5; i++)
            {
                string[] linie = sr.ReadLine().Split(' ');
                carti.Add(new Carte
                {
                    Denumire = linie[0],
                    NumarulDePagini = int.Parse(linie[1]),
                    Autor = linie[2]
                });
            }
            sr.Close();

            foreach(var carte in carti)
            {
                Console.WriteLine(carte.Denumire);
            }

            Console.ReadKey();
        }
    }
}
