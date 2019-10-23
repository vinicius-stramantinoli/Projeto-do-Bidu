using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while08
{
    class Program
    {
        static void Main(string[] args)
        {

            double i,numero, media,soma;

            i = 1;
            soma =  0; 

            while ( i <= 5)
            {
                Console.WriteLine("Infome o {0}º Número: " ,i );
                numero = double.Parse(Console.ReadLine());

                soma = soma + numero;

                i++;
            }

            media = soma / 10;

            Console.WriteLine("A soma dos Números é: {0} ", soma );
            Console.WriteLine("A soma dos Números é: {0} ", media );


            Console.ReadKey();
        }
    }
}
