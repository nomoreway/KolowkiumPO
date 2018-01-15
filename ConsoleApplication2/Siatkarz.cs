using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Siatkarz:Druzyna
    {
        protected string imie;
        protected string nazwisko;
        protected int numerNaKoszulce;

        public override string ToString()
        {
            return "Imie i nazwisko: " + imie + " " + nazwisko + ", Numer na koszulce: " + Convert.ToString(numerNaKoszulce);
        }
        protected Siatkarz(string imie, string nazwisko, int numer)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerNaKoszulce = numer;
        }
    }
}
