using System;

namespace Akademia1
{
    class Program
    {
        static void Main(string[] args)
        {
            // tablica
            int[] tab = new int[5];

            // zmienne
            int a = 10;

            // var - deklaracja typu który zostanie przypisany
            var jakisString = "ebe ebe ebe";
            var jakisInt = 4;
            var jakisFloat = 3.5f;

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Twoja tablica o rozmiarze {0}" ,tab.Length);

            foreach(var item in tab)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
