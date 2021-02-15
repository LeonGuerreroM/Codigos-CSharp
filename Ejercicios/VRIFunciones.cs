using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {

        public static double resistencia(double i, double v)
        {
            return v/i;
        }



        static void Main(string[] args)
        {
            double i,v,r;
            int n;
            char x;


            Console.WriteLine("Calculadora de V-R-I");


            do
            {
                Console.WriteLine("Seleccione que desea calcular");
                Console.WriteLine("(1)Resistencia\n(2)Corriente\n(3)Voltaje\n(4)Cancelar");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ingrese el voltaje");
                        v = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la corriente");
                        i = double.Parse(Console.ReadLine());
                        Console.WriteLine("El valor de la resistencia es: {0} ohms", Math.Round((resistencia(i, v)),2));
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el voltaje");
                        v = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la resistencia");
                        r = double.Parse(Console.ReadLine());
                        Console.WriteLine("El valor de la corriente es: {0} amperes", Math.Round((corriente(r, v)),2));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la corriente");
                        i = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la resistencia");
                        r = double.Parse(Console.ReadLine());
                        Console.WriteLine("El valor del voltaje es: {0} volts", Math.Round((voltaje(i, r)),2));
                        break;
                    case 4:
                        Console.WriteLine("Vuelva Pronto");
                        break;
                }

                Console.WriteLine("Si desea repetir presione s");
                x = char.ToUpper(char.Parse(Console.ReadLine()));
            } while (x == 'S');
            Console.ReadKey();

        }
    }
}
