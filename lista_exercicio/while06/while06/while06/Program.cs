using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while06
{
    class Program
    {
        static void Main(string[] args)
        {

            double i = 1;
            double produto = 1;

            while (i <= 15)
            {
                if(i % 2 != 0)
                {
                    

                    produto *= i;
                }
                i++;

                
            }
            Console.WriteLine(produto);


            Console.ReadKey();
        }
    }
}
