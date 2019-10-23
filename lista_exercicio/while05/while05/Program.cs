using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while05
{
    class Program
    {
        static void Main(string[] args)
        {

            int par, soma, i;

            i = 85;
            par = 85;
            soma = 0;
            while (i <= 907)
            {
                if(i % 2 == 0)
                {
                    par = i;
                    soma = soma + par;

                    Console.WriteLine(par);

                }
                i++;

                

            }
            Console.WriteLine("a soma e!" + soma);


            Console.ReadKey();
        }
    }
}
