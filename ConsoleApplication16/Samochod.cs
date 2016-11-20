using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Samochod:Pojazd
    {
        public string CzyDrogi()
        {
            if (ObliczKosztPaliwa(150, 5)>=75.0) return "Drogi"; 
            else return "Tani"; 
        }

    }
}
