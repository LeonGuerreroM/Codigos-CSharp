using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaDelCono
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;
            double radio, altura, volumen, area, lado;

            Console.WriteLine("Calculadora del area/volumen de un cono");
            Console.WriteLine("Ingrese el radio del cono");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cono");
            altura = double.Parse(Console.ReadLine());

            lado = Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
            Console.WriteLine("lado = {0}", lado);

            area = (2 * pi * radio * (lado / 2)) + (pi * (Math.Pow(radio, 2)));
            volumen = ((.3333) * pi * (Math.Pow(radio, 2)) * altura);

            

            Console.WriteLine("EL valor del area es: {0}\nEL valor del volumen es: {1}", Math.Round(area, 3), Math.Round(volumen, 3) );
            Console.ReadKey();

        }
    }
}
