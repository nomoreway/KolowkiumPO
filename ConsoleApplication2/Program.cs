using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("A - ustaw atak");
            Console.WriteLine("B - ustaw oborne");
            Console.WriteLine("C - ustaw nazwe");
            Console.WriteLine("X - wyjscie z aplikacji");
        }
        static void Main(string[] args)
        {
            string read;
            int a=0, b=0;
            Druzyna d1 = new Druzyna();
            Menu();
            while ((read=Console.ReadLine()) != "X")
            {
                if (read == "A")
                {
                    
                    try
                    {
                        if (a >= 4) throw new IndexOutOfRangeException();
                        Console.WriteLine("Podaj imie, nazwisko oraz numer koszulki zawodnika z ataku, zatwierdź enterami:");
                        d1.UstawAtak(a++, Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                    }

                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ustawiłeś już cały atak!");
                    }
                    catch (BlednyNumerException)
                    {

                    }
                    catch
                    {
                        Console.WriteLine("Wystąpił nieznany wyjątek!");
                    }
                }
                else if (read == "B")
                {
                    try
                    {
                        if (b >= 4) throw new IndexOutOfRangeException();
                        Console.WriteLine("Podaj imie, nazwisko oraz numer koszulki zawodnika z obrony, zatwierdź enterami:");
                        d1.UstawObrone(b++, Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ustawiłeś już całą obronę!");
                    }
                    catch (BlednyNumerException)
                    {

                    }
                    catch
                    {
                        Console.WriteLine("Wystąpił nieznany wyjątek!");
                    }
                }
                else if (read == "C")
                {
                    if (d1.CzyOK())
                    {
                        Console.WriteLine("Podaj nazwe druzyny, zatwierdź enterem:");
                        string nazwa = Console.ReadLine();
                        Console.WriteLine("Czy na pewno chcesz ustawić nazwe na {0}? Wcisnij Y aby kontynuować", nazwa);
                        if (Console.ReadLine() == "Y") d1.UstawNazwe(nazwa);

                    }
                    else Console.WriteLine("Drużyna nie jest skompletowana! Najwpierw skompletuj druzyne!");

                }
                else { Console.WriteLine("Nie wybrano poprawnej opcji, spróbuj ponownie!"); }

                Console.WriteLine("Nasicnij dowolny klawisz, aby kontunuować");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }
}
