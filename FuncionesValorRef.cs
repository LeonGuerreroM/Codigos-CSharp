using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {

        public static double calculo(double x)
        {
            const double refrendo = 499;
            double cobro;

            if (x <= 250000)
            {
                return refrendo;

            }
            else if (x > 250000)
            {
                cobro = (x * .128);
                return cobro;
            }
            else 
            {
                return 0;
            }

        }


        static void Main(string[] args)
        {
            //Ejemplo de sintaxis de una funcion
            //No importa donde va la funcion (claro...afuera del main, obvio)
            //Paso por valor
            /*public static float suma(int x, int y){
             * 
             * return valor;
             * 
             * } */

            //Y para mandarla a llamar? 
            //num=suma(1, 2); (o variables, claro)


            double valor,monto;

            Console.WriteLine("Calculador de pago de tenencia");
            Console.WriteLine("Ingrese el valor de su automovil");
            valor=int.Parse(Console.ReadLine());
            monto=calculo(valor);
            Console.WriteLine("Usted debe pagar: ${0}",monto);



            //paso de parametro popr valor, se envia una copia del valor (lo antes puesto)
            //Paso de parametros por referencia, envia la direccion de memoria y entonces no es una copia del valor, es el valor real y lo modifica. Si la funcion
            //modifica la variable enviada, entonces cuando en el main pida la variable enviada aunque la funcion nunca la haya retornado, va a imprimir la modificada por la funcion
            //pues accede a la misma direccion de memoria que otra funcion }(no l amain) ya cambio (el valor)
            //Paso por referencia
            /*public static float suma(ref int x, int y){ (solo a la que le ponga ref es por referencia, las otras son por valor)
            * 
            * return valor;
            * 
            * } */

            //Y para mandarla a llamar? 
            //num=suma(ref n1, m2);







            Console.ReadKey();

        }
    }
}
