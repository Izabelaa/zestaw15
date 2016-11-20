using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Autobus:Pojazd
    {
        private double iloscMiejsc=15;

        public Autobus() { }


        public Autobus(double iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
      
        }
        
      
        public double ObliczCeneZaBilet()
        {
            return ObliczKosztPaliwa(150,2)/iloscMiejsc;
        }
    }
}
