using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto1Cgatito
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   Console.WriteLine("Hola Mundo  desde C#"); //Clase Console con metodo writeLine para excribir. Este da unj salto de linea automatico
            Console.Write("Hola"); //metodo para escribir sin salkto de linea
            Console.WriteLine("Mundo \n\n\n"); 
            //compila y ejecuta con ctrl+F5


            Console.WriteLine("lock  | \t void | \t try");
            Console.WriteLine("out   | \t new  | \t null");
            Console.WriteLine("fixed | \t enum | \t implicit");
            Console.WriteLine("IS    | \t uint | \t struct");

            //---------------------------------------------------------

            int n1, n2, r;
            Console.WriteLine("Introduzca 2 valores");

            n1 = int.Parse(Console.ReadLine()); //metodo ReadLine de la clase Console para poder leer un dato  Notese que onvertimos lo que se cachga (metodo dentro de metodo en asignacion)
            //n2 = int.Parse(Console.ReadLine()); //datoAlQueSeConvertira.Parse para convertir a un tipo de dato
            n2 = Convert.ToInt16(Console.ReadLine()); //Convert toX para poder convertir variables

            //en el Convert si yo leo un valor NULL, lo convierte en 0. Para el Parse, es nulo y pues... muere

            r = n1 + n2;
            Console.WriteLine("La suma de " + n1 + " + " + n2 + " " + "es: " + r); //concatenamos con el +

            Console.WriteLine("La suma de {0} + {1} es: {2}", n1, n2, r); //imp0resion al estilo C con referencias de {} iniciando de 0 hasta... */

            //Inician Ejericcios 1 y 2

            int cant, bq, bd, bc, bcc, bv, cambio;
            Console.WriteLine("Conversor de dinero a billetes \n Introduzca la cantidad de dinero");
            cant = int.Parse(Console.ReadLine());

            bq = cant / 500;
            cant = cant % 500;

            bd = cant / 200;
            cant = cant % 200;

            bc = cant / 100;
            cant = cant % 100;

            bcc = cant / 50;
            cant = cant % 50;

            bv = cant / 20;
            cambio = cant % 20;

            Console.WriteLine("Billetes de 500: "+bq);
            Console.WriteLine("Billetes de 200: " + bd);
            Console.WriteLine("Billetes de 100: " + bc);
            Console.WriteLine("Billetes de 50: " + bcc);
            Console.WriteLine("Billetes de 20: "+bv);
            Console.WriteLine("Cambio: "+cambio);

 
            Console.ReadKey(); //para finalizar el proceso y compilar con el play

    }
    }
        }

