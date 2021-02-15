using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    class MiembroEscuela
    {
        public string nombre;
        public string numero;

        public MiembroEscuela(string x, string y)
        {
            this.nombre = x;
            this.numero = y;
        }

        public void entrarALaEscuela()
        {
            Console.WriteLine("Mostrando credencial para ingresar...");
        }
    }

    class Exalumno : MiembroEscuela
    {
        public int anioDeEgreso;

        public Exalumno(int a, string b, string c) :base(b,c)
        {
            anioDeEgreso = a;
        }

        public void buscarTrabajo()
        {
            Console.WriteLine("Buscando");
        }
    }

    class Estudiante : MiembroEscuela
    {
        public int grado;

        public Estudiante(string a, string b, int c) : base(a, b)
        {
            grado = c;
        }

        public void Estudiar()
        {
            Console.WriteLine("El alumno esta estudiando");
        }

        public void Reprobar()
        {
            Console.WriteLine("El alumno ha reprobado... :(");
        }
    }

    class Empleado : MiembroEscuela
    {
        public int antiguedad;
        
        public Empleado(int a, string b, string c) : base(b, c)
        {
            antiguedad = a;
        } 

        public void trabajar()
        {
            Console.WriteLine("El empleado esta trabajando");
        }
    }

    class Docente : Empleado
    {
        public string materia;
        public string grupo;

        public Docente(string a, string b, int c,string d, string e) : base(c,d,e)
        {
            materia = a;
            grupo = b;
        }

        public void darClases()
        {
            Console.WriteLine("El docente esta dando clases de {0} en el grupo {2}", materia, grupo);
        }
    }

    class Administrativo : Empleado
    {
        public string puesto;
        public char firma;

        public Administrativo(string a, char b, int c, string d, string e) : base(c, d, e)
        {
            puesto = a;
            firma = b;
        }

        public void firmar()
        {
            Console.WriteLine("El {0} esta firmando...",puesto);
        }
    }
}
