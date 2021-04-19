using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_systemów_liczbowych
{
    class System_binarny:Systemy
    {
        public override void Kalkuluj()
        {
        WprowadzPonownie:
            Console.WriteLine("\nWprowadź liczbę: ");

            //sprawdza czy /wprowadzonaLiczba/ ma wartość, czy jest pusta
            if (int.TryParse(Console.ReadLine(), out wprowadzonaLiczba)) 
            {  
                do
                {
                    if (wprowadzonaLiczba % 2 == 1) { resztaZDzielenia.Add(1); }
                    else { resztaZDzielenia.Add(0); }
                    wprowadzonaLiczba /= 2;

                }
                while (wprowadzonaLiczba > 0);
            }

            else
            {
                Console.Clear();
                goto WprowadzPonownie;
            }

            resztaZDzielenia.Reverse();

            Console.Write("\nTwoja liczba w systemie binarnym to: ");
            foreach (var liczba in resztaZDzielenia)
            {
                Console.Write(liczba);
            }
            Console.WriteLine("\n\nNaciśnij dowolny przycisk, aby wyjść.");
            Console.ReadKey();
        }
    }
}
