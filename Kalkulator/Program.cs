using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.Clear();
            Menu();
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Suma();
                    Kont();
                    break;
                case 2:
                    Roznica();
                    Kont();
                    break;
                case 3:
                    Iloczyn();
                    Kont();
                    break;
                case 4:
                    Iloraz();
                    Kont();
                    break;
                case 5:
                    Potega();
                    Kont();
                    break;
                case 6:
                    Pierwiastek();
                    Kont();
                    break;
                case 7:
                    FunkTryg();
                    Kont();
                    break;
                case 8:
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór (naciśnij dowolny klawisz aby kontynuować)");
                    Console.ReadKey();
                    Run();
                    break;
            }
        }
        static void Menu()
        {
            Console.WriteLine("Wybierz opcję:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Różnica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęga");
            Console.WriteLine("6. Pierwiastek");
            Console.WriteLine("7. Funkcje trygonometryczne");
            Console.WriteLine("8. Zakończ");
            Console.WriteLine();
        }
        static void Suma()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = a + b;
            Console.WriteLine("Suma liczb {0} i {1}: " + wynik, a, b);
        }
        static void Roznica()
        {
            Console.Write("Podaj odjemną: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj odjemnik: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = a - b;
            Console.WriteLine("Różnica liczb {0} i {1}: " + wynik, a, b);
        }
        static void Iloczyn()
        {
            Console.Write("Podaj pierwszy czynnik: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugi czynnik: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = a * b;
            Console.WriteLine("Iloczyn liczb {0} i {1}: " + wynik, a, b);
        }
        static void Iloraz()
        {
            Console.Write("Podaj dzielną: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj dzielnik: ");
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
                Console.WriteLine("Nie można dzielić przez 0");
            else
            {
                double wynik = a / b;
                Console.WriteLine("Iloraz liczb {0} i {1}: " + wynik, a, b);
            }
        }
        static void Potega()
        {
            Console.Write("Podaj podstawę: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj wykładnik: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = Math.Pow(a, b);
            Console.WriteLine("Potęga liczby {0} do liczby {1}: " + wynik, a, b);
        }
        static void Pierwiastek()
        {
            Console.Write("Podaj liczbę: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Podaj stopień pierwiastka: ");
            double b = double.Parse(Console.ReadLine());
            double wynik = Math.Pow(a, 1d / b);
            Console.WriteLine("Pierwiastek z liczby {0} stopnia {1}: " + wynik, a, b);
        }
        static void FunkTryg()
        {
            Console.Write("Podaj miarę kąta: ");
            double a = double.Parse(Console.ReadLine());
            double wynik = Math.Sin(a);
            Console.WriteLine("Sinus kąta o mierze {0}: " + wynik, a);
            wynik = Math.Cos(a);
            Console.WriteLine("Cosinus kąta o mierze {0}: " + wynik, a);
            wynik = Math.Tan(a);
            Console.WriteLine("Tangens kąta o mierze {0}: " + wynik, a);
        }
        static void Kont()
        {
            Console.WriteLine("Czy chcesz kontynuować? t/n");
            string l = Console.ReadLine();
            if (l=="t")
                Run();
        }
    }
}
