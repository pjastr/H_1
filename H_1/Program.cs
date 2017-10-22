using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pies pies1 = new Pies();
            pies1.UstawCzasPosilku(2);

            Pies pies2 = new Pies();
            pies2.UstawCzasPosilku(7);

            WlascicielPsa Janek = new WlascicielPsa();

            Console.WriteLine(Janek.ZabierzNaSpacer(pies1));
            Console.WriteLine(Janek.ZabierzNaSpacer(pies2));

            Console.ReadKey();
        }
    }
}
