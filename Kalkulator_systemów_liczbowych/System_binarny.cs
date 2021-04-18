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
            Console.WriteLine("\nWprowadź liczbę: ");
            wprowadzonaLiczba = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (wprowadzonaLiczba % 2 == 1) { resztaZDzielenia.Add(1); }
                else { resztaZDzielenia.Add(0); }
                wprowadzonaLiczba /= 2;

            }
            while (wprowadzonaLiczba > 0);

            resztaZDzielenia.Reverse();

            foreach (var liczba in resztaZDzielenia)
            {
                Console.Write(liczba);
            }
            Console.ReadKey();
        }
    }
}
