using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    public class empleado
    {
        public string nombre;
        public string apellido;
        public double salario;

        public empleado(string mat, string col, double mod)
        {
            nombre = mat;
            apellido = col;
            salario = mod;
        }

        public void anual()
        {
            Console.WriteLine("El salario anual de este empleado es de ${0}",salario * 12);
        }

        public void nuevo()
        {
            double salarioN = salario + (salario * .10);
            Console.WriteLine("El nuevo salario anual de este empleado es de ${0}", salarioN * 12);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            string w, x, y, z;
            double a, b;
            Console.WriteLine("Nombre Empleado 1:");
            w = Console.ReadLine();
            Console.WriteLine("Apellido Empleado 1:");
            x = Console.ReadLine();
            Console.WriteLine("Salario mensual Empelado 1:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nombre Empleado 2:");
            y = Console.ReadLine();
            Console.WriteLine("Apellido Empleado 2:");
            z = Console.ReadLine();
            Console.WriteLine("Salario mensual Empelado 2:");
            b = double.Parse(Console.ReadLine());

            empleado obj = new empleado(w, x, a);
            empleado obj1 = new empleado(y, z, b);

            Console.WriteLine("Empleado 1");
            obj.anual();
            Console.WriteLine("Empleado 2");
            obj1.anual();

            Console.WriteLine("Aplicando el aumento...");
            Console.WriteLine("Empleado 1");
            obj.nuevo();
            Console.WriteLine("Empleado 2");
            obj1.nuevo();



            Console.ReadKey();






        }
    }
}
