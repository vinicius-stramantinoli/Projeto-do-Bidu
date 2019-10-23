using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace while01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=1;

            while(cont <= 10000)
            {
                Console.WriteLine(cont);
                Thread.Sleep(500);
                cont++;
            }

            Console.ReadKey();
           
        }
    }
}
