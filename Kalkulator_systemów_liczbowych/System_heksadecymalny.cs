using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_systemów_liczbowych
{
    class System_heksadecymalny: Systemy
    {
        //Do zrobienia: konwersja liczb na litery 
        public override void Kalkuluj(int dzielnik, string nazwaSystemu)
        {
        WprowadzPonownie:
            Console.WriteLine("\nWprowadź liczbę: ");

            //sprawdza czy /wprowadzonaLiczba/ ma wartość, czy jest pusta
            if (int.TryParse(Console.ReadLine(), out wprowadzonaLiczba))
            {
                do
                {
                    reszta = wprowadzonaLiczba % dzielnik;
                    KonwertujNaLitery();
                    resztaZDzielenia.Add(reszta);
                    wprowadzonaLiczba /= dzielnik;

                }
                while (wprowadzonaLiczba > 0);
            }

            else
            {
                Console.Clear();
                goto WprowadzPonownie;
            }

            resztaZDzielenia.Reverse();

            Console.WriteLine(String.Format("\nTwoja liczba w systemie {0}m to: ", nazwaSystemu));

            foreach (var liczba in resztaZDzielenia)
            {
                Console.Write(liczba);
            }

        }
        public char KonwertujNaLitery()
        {
            
            switch (reszta)
            {
                case 10: {return = 'A';break; }
            }
        }
    }

    }
}
