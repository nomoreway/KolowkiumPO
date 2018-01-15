using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Druzyna:IDruzyna
    {
        private string nazwa;
        private Siatkarz[,] druzyna;



        public void UstawAtak(int p, string imie, string nazwisko, int numer)
        {
            druzyna[p, 1] = new Atak(imie, nazwisko, numer);

        }

        public void UstawObrone(int p, string imie, string nazwisko, int numer)
        {
            druzyna[p, 0] = new Obrona(imie, nazwisko, numer);
        }

        public void UstawNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public bool CzyOK()
        {
            foreach (Siatkarz element in druzyna)
            {
                if(element==null) return false;
            }
            return true;
        }
        //public override string ToString()
        //{
        //    foreach (Siatkarz element in druzyna)
        //    {
        //        if (element != null) return base.ToString();
        //    }
        //}
        public Druzyna()
        {
            this.druzyna = new Siatkarz[4, 2];
        }
    }
}
