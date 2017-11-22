using Akademia2.SamochodF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia2
{
    class Program
    {
        static void Main(string[] args)
        {
            // tworzymy silnik, przy tworzeniu klas/typow zlozonych potrzebne jest slowo kluczowe new
            Silnik silnik = new Silnik(); // <-- wywołanie bezparametrowego konstrktora

            Samochod mojSamochod = new Samochod("Audi", "S6", 2010, "Czerwony", "producentSilnika", 2005, 2.4);
            
            // pusta referencja (nie wskazuje na żaden obiekt w pamięci)
            Samochod referencja; 

            //przypisanie obiektu w pamieci do referencji
            referencja = new Samochod("Audi", "S6", 2010, "Czerwony", "producentSilnika", 2005, 2.4);

            Samochod referencja1 = referencja;
            // referencja/referencja1 wskazują na ten sam obiekt w pamięci tzn. że do danego samochodu możemy odwoływać się przez obie refrencje
            // referencje mozna nazywac "wskaznikiem" na dany samochod / lepiej nie mylic tego ze wskaznikami w C - działają troche inaczej
            Console.WriteLine(referencja);

            // tworze samochod bez silnika, korzystajac z jednego z konstruktorów (4-parametrowy)
            Samochod mojSamochodBezSilnika = new Samochod("Audi", "S6", 2010, "Czerwony");
            Silnik silnikDoSamochodu = new Silnik("producentSilnika", 2010, 4.3);

            // przypisuje samochod bezposrednio do pola silnika w obiekcie samochodu
            mojSamochodBezSilnika.silnikSamochodu = silnikDoSamochodu;

            // z klasy umieszczonej w innym folderze w projekcie / innym assembly mozemy korzystac jezeli dodamy using do miejsca gdzie klasa sie znajduje (w tym przypadku Akademia2.SamochodF
            Klasa1 klasazInnegoMiejsca = new Klasa1();

            Console.ReadKey();
        }
    }
}
