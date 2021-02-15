using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.WriteLine("Conversor de grados");
            Console.WriteLine("Ingrese la temperatura en Celsius");
            c = double.Parse(Console.ReadLine());

            f = ((1.8) * c) + 32;

            Console.WriteLine("La temperatura en Farenheit es: {0}°", f);

            Console.ReadKey();



        }
    }
}
