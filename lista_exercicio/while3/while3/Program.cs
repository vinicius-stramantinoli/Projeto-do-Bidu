using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while3
{
    class Program
    {
        static void Main(string[] args)
        {

            int par = 0, impar = 0,num, i = 1;

            while (i <= 10)
            {
                Console.WriteLine("Informe o número: ");
                num = int.Parse(Console.ReadLine());
                if(num % 2 == 0)
                {
                    par = par + 1;
                }
                else
                {
                    impar = impar + 1;
                }
                

                i++;

                
            }
            Console.WriteLine("Pares: " + par);
            Console.WriteLine("Impares: " + impar);



            Console.ReadKey();
        }
    }
}
