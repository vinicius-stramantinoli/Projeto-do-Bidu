using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while07
{
    class Program
    {
        static void Main(string[] args)
        {


            double numero, i, resp;
            i = 0;
             
            Console.WriteLine("Infome Qual tabuada vc deseja: ");
            numero = double.Parse(Console.ReadLine());
            

            while (i <= 10)
            {
                resp = i * numero;

                Console.WriteLine("{0} X {1} = {2} " ,i, numero , resp );

                i++;
            }

            Console.ReadKey();

        }
    }
}
