using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if22
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fija = 52.84;
            double kwh, cobro;
            Console.WriteLine("Bienvenido a la calculadora de cobro de luz");
            Console.WriteLine("Ingrese la cantidad de kwh que ha utilizado en este mes");
            kwh = double.Parse(Console.ReadLine());
            if (kwh == 0)
            {
                Console.WriteLine("Cuanto fija = ${0}",fija);
              
                Console.WriteLine("La cantidad que debe pagar es: ${0}", fija);
            }else if (kwh < 0)
            {

                Console.WriteLine("Ingrese un valor valido");
            }else  if(kwh>=1 && kwh <= 50)
            {
                cobro = fija + (kwh * 2.288);
                Console.WriteLine("Cuanto fija = ${0}", fija);
                Console.WriteLine("Los primeros 50 = ${0} quedan {1}",(kwh*2.288),(kwh-50) );
                Console.WriteLine("La cantidad que debe pagar es: ${0}", cobro);
            }else if(kwh >= 51 && kwh <= 100)
            {
                cobro = fija + (50 * 2.288) + ((kwh - 50) * 2.762);
                Console.WriteLine("Cuanto fija = ${0}", fija);
                Console.WriteLine("Los primeros 50 = ${0} quedan {1}", (50 * 2.288), (kwh - 50));
                Console.WriteLine("Del 51 al 100 = ${0} quedan {1}", (50 * 2.762), (kwh - 100));
                Console.WriteLine("La cantidad que debe pagar es: ${0}", cobro);
            }else if (kwh>100)
            {
                cobro = fija + (50 * 2.288) + ((50) * 2.762)+((kwh-100)*3.042);
                Console.WriteLine("Cuanto fija = ${0}", fija);
                Console.WriteLine("Los primeros 50 = ${0} quedan {1}", (50 * 2.288), (kwh - 50));
                Console.WriteLine("Del 51 al 100 = ${0} quedan {1}", (50 * 2.762), (kwh - 100));
                Console.WriteLine("Los {0} adicionales = ${1}",(kwh - 100), ((kwh - 100) * 3.042));
                Console.WriteLine("La cantidad que debe pagar es: ${0}", cobro);
            }

            Console.ReadKey();
        }







        }
    }

