using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class cuenta
    {
        public double saldo=100;

        public void depositar()
        {
            double deposito;
            Console.WriteLine("Cuanto desea depositar");
            deposito = double.Parse(Console.ReadLine());
            saldo = saldo + deposito;
        }

        public void consulta()
        {
            Console.WriteLine("Su saldo es de {0}$", saldo);
        }

        public void retirar()
        {
            double retiro;
            Console.WriteLine("Cuanto desea retirar");
            retiro = double.Parse(Console.ReadLine());
            if (retiro > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }else
            {
                saldo = saldo - retiro;
                Console.WriteLine("Saldo retirado\nSu saldo actual es de {0}$",saldo);
            }
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            
            cuenta obj = new cuenta();
            while (true) { 
            int x;
            Console.WriteLine("Escoja la opcion que desee\n1.Despositar\n2.Retirar\n3.Consultar\n4.Salir");
            x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        obj.depositar();
                        break;
                    case 2:
                        obj.retirar();
                        break;
                    case 3:
                        obj.consulta();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar este sistema");
                        break;
                    default:
                        Console.WriteLine("Valor invalido");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
