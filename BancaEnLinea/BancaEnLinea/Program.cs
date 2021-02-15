using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancaEnLinea;

namespace BancaEnLinea
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,contador=0;
            int x,a=11111111,b=22222222;
            double y,h,q=2000,w=10000;
            string u, c;
            char f;
            Cliente obj = new Cliente();
            Cuenta[] arrayObj = new Cuenta[obj.Num_cuentas];
            for (i = 0; i < obj.Num_cuentas; i++)
            {
                if (contador == 0)
                {
                    arrayObj[i] = new Cuenta(a,q);
                    contador++;
                }else if(contador==1)
                {
                    arrayObj[i] = new Cuenta(b, w);
                    contador++;
                }
            }
        
            Console.WriteLine("Banca en linea");
            Console.Write("Usuario ");
            u = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Contraseña ");
            c = Console.ReadLine();
            Console.WriteLine();

            if (u==obj.Usuario && c == obj.Contraseña)
            {
                do
                {
                    Console.WriteLine("Bienvenido {0}\nTus cuentas son:\n1. {1}\n2. {2}\n¿Que deseas hacer?\n1. Ver saldo\n2. Comprar Tiempo aire\n Opcion:", obj.Nombre, arrayObj[0].Num_cuenta, arrayObj[1].Num_cuenta);
                    x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("Cuenta: {0}  Saldo: {1}\nCuenta: {2}  Saldo: {3}", arrayObj[0].Num_cuenta, arrayObj[0].Saldo, arrayObj[1].Num_cuenta, arrayObj[1].Saldo);
                            break;
                        case 2:
                            Console.WriteLine("¿Cuanto desea comprar?");
                            h = double.Parse(Console.ReadLine());
                            //comprarTiempoAire(h);
                            Console.WriteLine("¿Que cuenta?");
                            Console.WriteLine("1. {0} \n2. {1}", arrayObj[0].Num_cuenta, arrayObj[1].Num_cuenta);
                            j = int.Parse(Console.ReadLine());
                            j = j - 1;
                            arrayObj[j].comprarTiempoAire(h);
                            Console.WriteLine("Nuevo saldo: {0}", arrayObj[j].Saldo);
                            break;
                        default:
                            Console.WriteLine("Valor no valido");
                            break;

                    }
                    Console.WriteLine("Si desea repetir el menu, presione s; en caso contrario presione otra tecla");
                    f = char.ToLower(char.Parse(Console.ReadLine()));
                } while (f == 's');

            }
            else
            {
                Console.WriteLine("Usuario o contraseña invalidos");
            }



        }
    }
}
