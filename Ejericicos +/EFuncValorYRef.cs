using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplic
{
    class Program
    {

        public static int edadC(int x, int y, int z, int a, int b, int c)
        {
            int edad;

            if(y > b)
            {
                edad = z - c; 
            }else if(y==b && x > a)
            {
                edad = z - c;
            }
            else
            {
                edad = (z - c)-1;
            }

            return edad;



        }

        public static void edadR(int x, int y, int z, int a, int b, int c, ref int edad)
        {
            

            if (y > b)
            {
                edad = z - c;
            }
            else if (y == b && x > a)
            {
                edad = z - c;
            }
            else
            {
                edad = (z - c) - 1;
            }

            

        }









            static void Main(string[] args)
        {
            int da, ma, aa;
            int dn, mn, an;
            int resultado,edad=0;

            Console.WriteLine("Calculadora de edad");
            Console.WriteLine("Ingrese la fecha actual");
            Console.WriteLine("Dia");
            da = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes");
            ma = int.Parse(Console.ReadLine());
            Console.WriteLine("Anio");
            aa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su fecha de nacimiento");
            Console.WriteLine("Dia");
            dn = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes");
            mn = int.Parse(Console.ReadLine());
            Console.WriteLine("Anio");
            an = int.Parse(Console.ReadLine());

    resultado = edadC(da, ma, aa, dn, mn, an);
    Console.WriteLine("Usted tiene {0}", resultado);
    //edadR(da, ma, aa, dn, mn, an, ref edad);

    //Console.WriteLine("Usted tiene {0}",edad);




            Console.ReadKey();








        }
    }
}
