using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Rectangulo
    {
        public double b;
        public double altura;

        //no necesito paso de parametros en orientado a objetos, los metodos ya tienen acceso a los parametros de la clase directamente
        public void Perimetro(){ //sin static porque pertenece a la clase (tal vez eso lo deja acceder a los atributos de la clase sin paso de parametros)
            double res = 2 * (b + altura);
            Console.WriteLine("El perimetro es: {0}", res);
        }

        public double Area()
        {
            return b*altura;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo obj = new Rectangulo(); //instancia
            Rectangulo obj1 = new Rectangulo();
            obj.b = 50; //asignacion de variable cuando no hay constructor (uno por uno). Indica a cual objeto pertenece ese atributo
            obj.altura = 30;
            obj.Perimetro();
            Console.WriteLine("El area es : {0}", obj.Area()); //impresion de variable retornada por este metodo. Si no, se pierde. Es esto o asignarlo a una variable e imprimir una variable

            Console.WriteLine("Base del rectangulo 2");
            obj1.b = double.Parse(Console.ReadLine()); //ingreso de variable de objeto por teclado
            Console.WriteLine("Altura del rectangulo 2");
            obj1.altura = double.Parse(Console.ReadLine());

            obj1.Perimetro();
            Console.WriteLine("El area es : {0}", obj1.Area());


            //public: todos accede a el
            //private: solo acceden los miembros de la clase
            //protected: para herencia, solo clases hijas
            Console.ReadKey();
        }
    }
}
