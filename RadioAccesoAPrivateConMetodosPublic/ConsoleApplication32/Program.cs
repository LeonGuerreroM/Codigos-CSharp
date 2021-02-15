using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication32;
namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b/*,e*/;
            double c;
            char d;
            Radio obj = new Radio();
            Console.WriteLine("Estereo Encendido");
            do
            {
            obj.mostrarDatos();
            Console.WriteLine("Elija la opcion que desee\n1.Aumentar Frecuencia\n2.Disminuir Frecuencia\n3.Aumentar Volumen\n4.Disminuir Frecuencia");
            a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("¿Cuanto quiere aumentar la frecuencia?");
                        c = double.Parse(Console.ReadLine());
                        obj.aumentarFrecuencia(c);
                        break;
                    case 2:
                        Console.WriteLine("¿Cuanto quiere disminuir la frecuencia?");
                        c = double.Parse(Console.ReadLine());
                        obj.disminuirFrecuencia(c);
                        break;
                    case 3:
                        Console.WriteLine("¿Cuanto quiere aumentar el volumen?");
                        b = int.Parse(Console.ReadLine());
                        obj.aumentarVolumen(b);
                        break;
                    case 4:
                        Console.WriteLine("¿Cuanto quiere disminuir el volumen?");
                        b = int.Parse(Console.ReadLine());
                        obj.disminuirVolumen(b);
                        break;
                    default:
                        Console.WriteLine("Valor no aceptado. Intente de nuevo");
                        break;
                }
                Console.WriteLine("Si desea repetir el menu, presione S\nEn caso contrario, presione otra tecla");
                d = char.ToLower(char.Parse(Console.ReadLine()));
            } while (d == 's');

            
            //Console.ReadKey();
        }
    }
}
