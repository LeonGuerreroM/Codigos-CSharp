using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CajeroObj2;

namespace CajeroObj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta obj = new Cuenta(12345678, 5000);
            int x;
            char y;
            obj.saldos();
            do
            {
                Console.WriteLine("Seleccione una opcion\n1.Realizar retiro\n2.Comprar tiempo aire");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        obj.Retiro();
                        break;
                    case 2:
                        obj.comprarTiempoAire();
                        break;
                    default:
                        Console.WriteLine("Valor no valido");
                        break;
                }
                Console.WriteLine("Si desea repetir el menu, presione s. En caso contrario, presione cualquier otra tecla");
                y = char.ToLower(char.Parse(Console.ReadLine()));
            } while (y == 's');

            

        }
    }
}
