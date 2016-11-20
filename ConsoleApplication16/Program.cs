using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Autobus autob1 = new Autobus();
            Console.WriteLine("cena biletu {0}" ,(double) autob1.ObliczCeneZaBilet());

         Samochod sam1= new Samochod();
         Console.WriteLine(sam1.CzyDrogi());

            Console.ReadKey();
        }
    }
}
