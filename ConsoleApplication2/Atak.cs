using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Atak:Siatkarz
    {
        private static int Valide(int n)
        {
            if (n % 2 != 1) throw new BlednyNumerException();
            else return n;
        }

        public Atak(string imie, string nazwisko, int numer):base(imie,nazwisko, Valide(numer))
        {
          
        }
        public override string ToString()
        {
            return "Atak" + base.ToString();
        }

       
    }
}
