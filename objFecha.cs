using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class fecha
    {
        int d,m,a;
        DateTime obj = DateTime.Today;

        public void iniciar_fecha(){
            d=obj.Day;
            m=obj.Month;
            a=obj.Year;
        }
        public void imprimir(){
            Console.WriteLine("Fecha: {0}/{1}/{2}",d,m,a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fecha obj1 = new fecha();

            obj1.iniciar_fecha();
            obj1.imprimir();

            Console.ReadKey();
        }
    }
}
