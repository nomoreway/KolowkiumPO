using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Obrona:Siatkarz
    {
           private static int Valide(int n)
        {
            if (n % 2 != 0) throw new BlednyNumerException();
            else return n;
        }

           public Obrona(string imie, string nazwisko, int numer)
               : base(imie, nazwisko, Valide(numer))
           {
               
           }
           public override string ToString()
           {
               return "Obrona" + base.ToString();
           }
           
    }
}
