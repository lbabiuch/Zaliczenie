using System;
using System.Collections.Generic;
using System.Linq;

namespace Zaliczenie
{
    class Program
    {
        static void Main()
        {
            //Zadanie pierwsze
            Random random = new Random();

            var losowe = new int[100];
            for (int i = 0; i < 100; i++)
            {
                losowe[i] = random.Next(-1000, 1000);
            }
            IEnumerable<int> kolekcja = losowe.ToList();

            var srednia = kolekcja.Average();
            var minimum = kolekcja.Min();
            var maksimum = kolekcja.Max();
            var stankonta = 0;
            foreach (var item in kolekcja)
            {
                stankonta = stankonta + item;
            }
            var ileUjemnych = kolekcja.Where(x => x < 0).Count();
            var ileDodatnich = kolekcja.Where(x => x > 0).Count();
            Console.WriteLine($"Srednia: {srednia}");
            Console.WriteLine($"Min: {minimum}");
            Console.WriteLine($"Max: {maksimum}");
            Console.WriteLine($"Stan konta: {stankonta}");
            Console.WriteLine($"Ile ujemnych: {ileUjemnych}");
            Console.WriteLine($"Ile dodatnich: {ileDodatnich}");


            //Zadanie drugie
            Smartfon Nokia3310 = new Smartfon();
            Nokia3310.LadujStroneWWW("https://ccig.pl/");
            Nokia3310.Dzwon("997");

            Smartfon XPhone = new Smartfon();
            XPhone.LadujStroneWWW("jakis adres");
            XPhone.Dzwon("jakis numer");
        }
    }
}
