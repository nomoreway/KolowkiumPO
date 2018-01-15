using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    interface IDruzyna
    {
        void UstawAtak(int p, string imie, string nazwisko, int numer);
        void UstawObrone(int p, string imie, string nazwisko, int numer);
        void UstawNazwe(string nazwa);
        bool CzyOK();


    }
}
