using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zaliczenie
{
    public interface IDostawca
    {
        /*Produkt Wyszukaj(string nazwa)
        {
        }*/

        public void Zamow(Produkt produkt)
        {
        }
    }
    public class Adidas : IDostawca
    {
    }
    public class Nike : IDostawca
    {

    }

    public enum Produkt
    {
    }
}