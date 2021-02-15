using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            const double aumento = 0.5;
            double i,x;

            for (i = 0; i <= 10; i+=aumento)
            {
                x = Math.Sin(2*i) - i;
                Console.WriteLine("El resultado de f(x)=sin(2({0}))-{1} es: {2}", i, i, x);
            }

            Console.ReadKey();


        }
    }
}
