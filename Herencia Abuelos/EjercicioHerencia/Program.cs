using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            MiembroEscuela obj = new MiembroEscuela("Math", "11111");
            Exalumno obj1 = new Exalumno(2017, "Pat", "12345");
            Estudiante obj2 = new Estudiante("Leon", "4762015", 1);
            Empleado obj3 = new Empleado(3, "Vanessa", "2345");
            Docente obj4 = new Docente("Calculo", "1TV1", 6, "Juan", "9898908");
            Administrativo obj5 = new Administrativo("Subdirector", 'x', 10, "Olly", "333333");

            Console.WriteLine("Nombre: {0} Numero de Boleta: {1}", obj1.nombre, obj1.numero);
            Console.WriteLine("Nombre: {0} Numero de Boleta: {1}", obj2.nombre, obj2.numero);
            Console.WriteLine("Nombre: {0} Numero de Empleado: {1}", obj4.nombre, obj4.numero);

            Console.WriteLine("\nAtributos Miembro Escuela\nNombre: {0} Numero: {1}", obj.nombre, obj.numero);
            Console.WriteLine("Atributos Exalumno\nNombre: {0} Anio de Egreso: {1}", obj1.nombre, obj1.anioDeEgreso);
            Console.WriteLine("Atributos Estudiante\nNombre: {0} Grado: {1}", obj2.nombre, obj2.grado);
            Console.WriteLine("Atributos Empleado\nNombre: {0} Años de trabajo: {1}", obj3.nombre, obj3.antiguedad);
            Console.WriteLine("Atributos Docente\nMateria: {0} Grupo: {1}", obj4.materia, obj4.grupo);
            Console.WriteLine("Atributos Administrativo\nPuesto: {0} Firma: {1}", obj5.puesto, obj5.firma);


            Console.ReadKey();




        }
    }
}
