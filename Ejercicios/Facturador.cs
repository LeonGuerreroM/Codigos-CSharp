using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fcaturador
{
    class Program
    {
        static void Main(string[] args)
        {
            int cd1, cd2, cant1, cant2;
            string des1, des2;
            double precio1, precio2, subtotal, iva, total, st1, st2;
            const double iv= 0.16;

            Console.WriteLine("Bienvenido al Facturador electronico");
            Console.WriteLine("Por favor introduzca los datos que se solicitaran a continuacion");
            Console.WriteLine("Producto 1 \nCodigo");
            cd1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Descripcion");
            des1 = Console.ReadLine();
            Console.WriteLine("Cantidad");
            cant1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio");
            precio1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nProducto 2 \nCodigo");
            cd2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Descripcion");
            des2 = Console.ReadLine();
            Console.WriteLine("Cantidad");
            cant2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio");
            precio2 = float.Parse(Console.ReadLine());



            st1 = cant1 * precio1;
            st2 = cant2 * precio2;
            subtotal = st1+st2;
            iva = (subtotal * iv);
            total = subtotal + iva;

            Console.WriteLine("\n\n");
            Console.WriteLine("Codigo\tDescripcion\tCantidad\tPrecio");
            Console.WriteLine("{0}\t{1}\t               {2}\t     {3}",cd1, des1, cant1, precio1);
            Console.WriteLine("{0}\t{1}\t               {2}\t     {3}",cd2, des2, cant2, precio2);
            Console.WriteLine("\t\t\t\t      __________");
            Console.WriteLine("\n\t\t\tSubtotal\t" + subtotal.ToString("C", System.Globalization.CultureInfo.CurrentCulture));
            Console.WriteLine("\t\t\tIVA     \t" + iva.ToString("C", System.Globalization.CultureInfo.CurrentCulture));
            Console.WriteLine("\t\t\tTotal   \t" + total.ToString("C", System.Globalization.CultureInfo.CurrentCulture));
           

            


           



            Console.ReadKey();
        }
    }
}
