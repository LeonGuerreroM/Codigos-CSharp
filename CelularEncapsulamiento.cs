using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class celular
    {
        private long numero=5578715591; //para encapsularlo usa el private
        long numeroC;
        public double saldo=20; //recuerda que publico me ayuda a que el main (y todo) pueda accesar a esta variable
        string mensaje1;
        //metodos publicos con atributos privados y asi solo podemos accesar a ellos con los metodos
        public void llamar()
        {
            Console.WriteLine("Indique el numero al que desea llamar");
            numeroC = long.Parse(Console.ReadLine());
            if (saldo >= 10)
            {
                Console.WriteLine("Llamando...");
                Thread.Sleep(2000);
                Console.WriteLine("Llamanda terminada");
                saldo = saldo - 10;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void mensaje()
        {
            Console.WriteLine("Indique el numero al que desea mandar mensaje");
            numeroC = long.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el mensaje");
            mensaje1 = Console.ReadLine();
            if (saldo >= 5)
            {
                Console.WriteLine("Enviando...");
                Thread.Sleep(2000);
                Console.WriteLine("Mensaje enviado");
                saldo = saldo - 5;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente\nEl mensaje no fue enviado");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            celular obj = new celular();
            int x;
            char s;
            do
            {
                Console.WriteLine("Su saldo es de {0}",obj.saldo);
                Console.WriteLine("Escoja la opcion que desee\n1.Llamar\n2.Enviar Mensaje\n3.Salir");
                x = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (x)
                {
                    case 1:
                        obj.llamar();
                        break;
                    case 2:
                        obj.mensaje();
                        break;
                    case 3:
                        Console.WriteLine("Hasta luego :D");
                        break;
                    default:
                        Console.WriteLine("Valor invalido");
                        break;
                }
                Console.WriteLine("Si desea repetir el menu presione s\nEn caso contrario presione cualquier otra tecla");
                s = char.ToUpper(char.Parse(Console.ReadLine()));
            } while (s == 'S');
            Console.ReadKey();
        }
        
    }
}
