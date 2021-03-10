using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Sarcina1
{
    // Companie de constructii:

    class Cladire
    {
        public string Nume { get; set; }
        public double Pret { get; set; }
        public string Contractant { get; set; }
        public DateTime DataSemnariiContractului { get; set; }

        public virtual void Materiale()
        {
            Console.WriteLine("Lemn");
            Console.WriteLine("Ciment");
            Console.WriteLine("Nisip");
            Console.WriteLine("Combustibil");
        }
    }

    class InstitutieDeInvatamant : Cladire
    {
        public string Tip { get; set; } // Gimnaziu, Liceu, Colegiu, Universitate etc.
        
        public override void Materiale()
        {
            Console.WriteLine("Materiale necesare pentru constructia unei " +
                "institutii de invatamant");
            base.Materiale();
            Console.WriteLine("Banci");
            Console.WriteLine("Calculatoare");
            Console.WriteLine("Proiectoare");
        }
    }

    class Hotel : Cladire
    {
        public int NrStele { get; set; }

        public override void Materiale()
        {
            Console.WriteLine("Materiale necesare pentru constructia unui hotel");
            base.Materiale();
            Console.WriteLine("Mobilier Receptie");
            Console.WriteLine("Paturi");
            Console.WriteLine("Dulapuri");
        }
    }

    class Spital : Cladire
    {
        public int NrMaximPacienti { get; set; }

        public override void Materiale()
        {
            Console.WriteLine("Materiale necesare pentru constructia unui spital");
            base.Materiale();
            Console.WriteLine("Paturi");
            Console.WriteLine("Dulapuri");
            Console.WriteLine("Echipamente medicale");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Cladire> cladiri = new List<Cladire>();

            InstitutieDeInvatamant institutieDeInvatamant1 = new InstitutieDeInvatamant
            {
                Contractant = "John",
                DataSemnariiContractului = DateTime.Parse("05/05/2021"),
                Nume = "Harvard",
                Tip = "Universitate",
                Pret = 20000000
            };

            InstitutieDeInvatamant institutieDeInvatamant2 = new InstitutieDeInvatamant
            {
                Contractant = "Andrei",
                DataSemnariiContractului = DateTime.Parse("05/01/2021"),
                Nume = "Colegiu Iulia Hadeu",
                Tip = "Colegiu",
                Pret = 200000
            };

            Spital spital1 = new Spital
            {
                Contractant = "Vasile",
                DataSemnariiContractului = DateTime.Parse("01/01/2021"),
                NrMaximPacienti = 250,
                Nume = "Spitalul Republican",
                Pret = 5000000
            };

            Spital spital2 = new Spital
            {
                Contractant = "Vlad",
                DataSemnariiContractului = DateTime.Parse("01/01/2021"),
                NrMaximPacienti = 130,
                Nume = "Spitalul Raional Cahul",
                Pret = 1500000
            };

            Hotel hotel1 = new Hotel
            {
                Contractant = "Mihail",
                DataSemnariiContractului = DateTime.Parse("01/01/2021"),
                NrStele = 4,
                Nume = "Alba",
                Pret = 3000000
            };

            Hotel hotel2 = new Hotel
            {
                Contractant = "Stefan",
                DataSemnariiContractului = DateTime.Parse("01/01/2021"),
                NrStele = 4,
                Nume = "Trump",
                Pret = 30000000
            };

            cladiri.Add(institutieDeInvatamant1);
            cladiri.Add(institutieDeInvatamant2);
            cladiri.Add(spital1);
            cladiri.Add(spital2);
            cladiri.Add(hotel1);
            cladiri.Add(hotel2);

            //var cladirePretMax = cladiri.FirstOrDefault(qu => qu.Pret == cladiri.Max(qu => qu.Pret));

            double pretMaxim = 0;
            Cladire cladirePretMax = new Cladire();

            foreach (Cladire cladire in cladiri)
            {
                if(cladire.Pret > pretMaxim)
                {
                    pretMaxim = cladire.Pret;
                    cladirePretMax = cladire;
                }
            }
            Console.WriteLine($"Cladirea cu pretul maxim de constructie: {cladirePretMax.Nume}" );
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("\nMaterialele necesare pentru a construi cladirile:");
            foreach (Cladire cladire in cladiri)
            {
                Console.WriteLine(cladire.Nume);
                cladire.Materiale();
                Console.WriteLine();
            }
        }
    }
}
