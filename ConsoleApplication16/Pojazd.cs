using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Pojazd
    {
        protected string marka;
        protected double srednieSpalanie=4.5;

        public Pojazd() { }

        public Pojazd(string marka, double srednieSpalanie )
        {
            this.marka = marka;
            this.srednieSpalanie = srednieSpalanie;
        }

        public double ObliczSpalanie(double dlTrasy)
        {
            return srednieSpalanie * dlTrasy / 100;
        }

        public double ObliczKosztPaliwa(double dlTrasy, double cenaPaliwa)
        {
           return ObliczSpalanie(dlTrasy) * cenaPaliwa;
           
        }
    }
}
