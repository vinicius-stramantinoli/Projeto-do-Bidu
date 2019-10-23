using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while02
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, soma = 0;
        

            while(cont <= 100)
            {
                soma = soma + cont;
                cont = cont + 1;
               
            }
            Console.WriteLine("A soma dos números de 1 a 100 é: "+ soma);
            Console.ReadKey();
        }
    }
}
