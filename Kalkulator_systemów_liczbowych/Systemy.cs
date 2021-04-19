using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_systemów_liczbowych
{
    abstract class Systemy
    {
        
        public List<int> resztaZDzielenia = new List<int>();
        public int wprowadzonaLiczba;
        public abstract void Kalkuluj();
        
        
    }

    
}
