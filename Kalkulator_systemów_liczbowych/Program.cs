using System;
using System.Collections.Generic;

namespace Kalkulator_systemów_liczbowych
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz system liczbowy, na który chcesz przekonwertować liczbę:");
            Console.WriteLine("1.)Binarny");
            Console.WriteLine("2.)Oktalny");
            Console.WriteLine("3.)Heksadecymalny");
            Console.WriteLine("4.)Dziesiętny");
            int wyborMenu = Convert.ToInt32(Console.ReadLine());
            

            switch(wyborMenu)
            {
                case 1: { System_binarny binarny = new System_binarny(); binarny.Kalkuluj(); break; }
                case 2:  break;
                case 3:  break;
                case 4:  break;

            }
            

            
        }
    }
}
