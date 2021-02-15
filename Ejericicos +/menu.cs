using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double cantidad, total,seleccion;
            Console.WriteLine("Seleccione el paquete que desea comprar");
            Console.WriteLine("Hamburguesa chica con papas y refresco $20");
            Console.WriteLine("Hot dog y refresco $18");
            Console.WriteLine("Ensalada rusa $15");
            Console.WriteLine("Salir");

            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado la hamburguesa");
                    seleccion = 20;
                    Console.WriteLine("Indique el numero de unidades de estos productos que desea");
                    cantidad = double.Parse(Console.ReadLine());
                    total = (seleccion * cantidad);
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado el hot dog con papas");
                    seleccion = 18;
                    Console.WriteLine("Indique el numero de unidades de estos productos que desea");
                    cantidad = double.Parse(Console.ReadLine());
                    total = (seleccion * cantidad);
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionado la ensalada rusa");
                    seleccion = 15;
                    Console.WriteLine("Indique el numero de unidades de este producto, que desea");
                    cantidad = double.Parse(Console.ReadLine());
                    total = (seleccion * cantidad);
                    break;
                case 4:
                    Console.WriteLine("Ha seleccionado salir");
                    Console.WriteLine("Vuelva pronto :)");
                    break;
                default:
                    Console.WriteLine("Valor invalido");
                    break;
            }





        }
    }
}
