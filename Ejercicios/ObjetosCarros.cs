using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    public class carro
    {
        public int matricula;
        public string color;
        public int modelo;

        public carro(int mat, string col, int mod)
        {
            matricula = mat;
            color = col;
            modelo = mod;
        }

        public void imprimir()
        {
            Console.WriteLine("Matricula: {0}",matricula);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Modelo: {0}", modelo);
        }


    }



    class Program
    {
     
        static void Main(string[] args)
        {
            int w, x, y, z;
            string a, b;
            Console.WriteLine("Matricula auto1:");
            w= int.Parse(Console.ReadLine());
            Console.WriteLine("Color auto1:");
            a= Console.ReadLine();
            Console.WriteLine("Modelo auto1:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Matricula auto2:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Color auto2:");
            b = Console.ReadLine();
            Console.WriteLine("Modelo auto2:");
            z = int.Parse(Console.ReadLine());

            carro obj = new carro(w,a,x);
            carro obj1 = new carro(y,b,z);

            obj.imprimir();
            obj1.imprimir();


            Console.ReadKey();
        }

    }
}
