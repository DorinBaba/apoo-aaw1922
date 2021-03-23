using System;

namespace LectieDeSintezaAAW
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Tipurile de polimorfism
            // 1.1: Polimorfism static
            // 1.2: Polimorfism dinamic 

            // 2. Supraincarcarea metodelor
            //    - Atunci cand mai multe metode cu acelasi nume, dar numar si / sau
            //    tip diferit de parametri in aceeasi clasa. 
            //    exemplu: Suma(int a, int b);
            //             Suma(int a, int b, int c);

            // 3. Supraincarcarea operatorilor 
            //    - Oferim functionalitate operatorilor asupra tipurilor definite 
            //    de utilizator.
            //    
            //    Indicati ce operator poate fi inserat: +, -, *, /
            //    public static Fractie operator [...](Fractie fractie1, Fractie fractie2)

            //    Indicati ce operator poate fi inserat: --, ++
            //    public static Fractie operator [...](Fractie fractie1)

            // 4. Supradefinirea metodelor
            //    - Atunci cand clasa derivata ofera o noua implementare unei metode
            //    care a fost deja definita in clasa de baza
            //    Clasa Persoana -> Afisare() * Afiseaza numele si prenumele.
            //    Clasa Angajat : Persoana -> Afisare() * Afiseaza numele, prenumele, salariu.

            // 5. Listele generice
        }
    }
}
