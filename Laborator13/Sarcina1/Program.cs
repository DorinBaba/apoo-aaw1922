using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Sarcina1
{
    class CeaMaiSmecheraListaDeLaIisusHristosIncoace<T>
    {
        public List<T> Lista { get; set; } = new List<T>();

        public void Add(T item)
        {
            if(Lista.Count == 0)
            {
                Lista.Add(item);
                return;
            }

            int randomIndex = (new Random()).Next(0, Lista.Count);

            List<T> lista1 = Lista.GetRange(0, randomIndex);
            lista1.Add(item);
            List<T> lista2 = Lista.GetRange(randomIndex, Lista.Count - randomIndex);
            
            Lista = lista1.Concat(lista2).ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CeaMaiSmecheraListaDeLaIisusHristosIncoace<int> listaSmechera = new CeaMaiSmecheraListaDeLaIisusHristosIncoace<int>();
            listaSmechera.Add(1);
            listaSmechera.Add(2);

            foreach (var item in listaSmechera.Lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
