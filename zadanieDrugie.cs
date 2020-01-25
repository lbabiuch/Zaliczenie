using System;
using System.Collections.Generic;
using System.Text;

namespace Zaliczenie
{
    public class Telefon
    {
        public void Dzwon(string phonerNumber)
        {
            Console.WriteLine($"Dzwonie na {phonerNumber}");
        }
    }
    public class Smartfon : Telefon
    {
        public void LadujStroneWWW(string link)
        {
            Console.WriteLine($"Ładuje strone {link}");
        }
    }
}
