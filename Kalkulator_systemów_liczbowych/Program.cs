using System;
using System.Collections.Generic;

namespace Kalkulator_systemów_liczbowych
{
    class Program
    {
        static void Main(string[] args)
        {
            WybierzOpcje:
            Console.WriteLine("Wybierz system liczbowy, na który chcesz przekonwertować liczbę:");
            Console.WriteLine("1.)Binarny");
            Console.WriteLine("2.)Oktalny");
            Console.WriteLine("3.)Heksadecymalny");
            Console.WriteLine("4.)Dziesiętny");
            int wyborMenu = Convert.ToInt32(Console.ReadLine());
            Systemy systemy = new Systemy();
            System_heksadecymalny decymalny = new System_heksadecymalny();

            switch(wyborMenu)
            {
                case 1: { systemy.Kalkuluj(2,"binarny"); break; }
                case 2: { systemy.Kalkuluj(8,"oktalny"); break; }
                case 3: { decymalny.Kalkuluj(16,"heksadecymalny"); break; }
                case 4: { systemy.Kalkuluj(2,"dziesiętny"); break; }
                default: { Console.WriteLine("Wprowadzono nieprawidłową liczbę!"); goto WybierzOpcje;}
            }
            
            Console.WriteLine("\n\nNaciśnij dowolny przycisk, aby wyjść.");
            Console.ReadKey();
            
        }
    }
}
