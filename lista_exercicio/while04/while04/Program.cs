using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while04
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0, num, i = 1;

            while (i <= 3)
            {
                Console.WriteLine("Informe o número: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    par = par + num;
                }
                else
                {
                    impar = impar + num;
                }


                i++;


            }
            Console.WriteLine("A soma dos números pares é: " + par);
            Console.WriteLine("A soma dos números ímpares é: " + impar);

            Console.ReadKey();
        }

        
    }
}
