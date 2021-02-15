using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class celular
    {
        private long numero; //para encapsularlo usa el private. Solo la clase accede a el
        long numeroC;
        public double saldo; //recuerda que publico me ayuda a que el main (y todo) pueda accesar a esta variable
        string mensaje1;
        //metodos publicos con atributos privados y asi solo podemos accesar a ellos con los metodos

        //constructor por defecto, recibe 0 parametros
        public celular() //su modificador de acceso debe ser publico
        {
            //esta es la forma "correcta" de asignar valores a las variables de la clase
            numero = 5547364593;
            saldo = 20; //saldo=100.0f para que C# entienda que es un double 
        }//Una clase puede tener varios constructores
        //constructor por parametro
        public celular(long n, int s) //Asigna valores recibidos a los valores de la calse
        {
            numero = n;
            saldo = s; 

        }
        public celular(int s)
        {
            //no puede haber dos constructores igualitos porque si no, no sabe cual llamar
            //va a llamar este cuando solo envie un int, sabrá cual llamar de acuerdo a los parametros que envie el objeto
            saldo = s;
        }
        //el destructor se ejcuta antes de destruir el objeto
        //Detructor. No acepta parametros y solo puede ser uno

        ~celular() //sin modificador de acceso
            //se ejcuta al acabar de usar el objeto (al terminar el programa. Mata todos, TODOS los objetos
        {
            Console.WriteLine("Ya fue UnU");
        }

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
            celular obj1 = new celular(5534562341, 200);//envio de paramtros al constructor por parametro desde la creacion del objeto
            celular obj2 = new celular(5511111111, 5); //claro, pueden ser fijos o variables con valores ingresados por teclado
            celular obj3 = new celular(500);
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
