using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herenciaAnimal
{
    class Animal
    {
        public string color;
        public double tamanio;
        /*protected*/ public double peso; //permite la herencia pero solo desde la clase, no desde el main donde cree el objeto

        public Animal(string a, double b, double c)
        {
            color = a;
            tamanio = b;
            peso = c;
        }

        public void correr()
        {
            Console.WriteLine("Este animal está corriendo");
        }

        public void dormir()
        {
            Console.WriteLine("Este animal está dormiendo");
        }




    }

    class Herbivoro : Animal //clase que hereda clase hija : clase padre
    //se hereda TODO lo publico y protegido
    {
        public string comida;
        public Herbivoro(string a, string com, double b, double c):base(a,b,c) //la base es para enviar parametros de la clase hija a la clase padre
        {
            comida = com; //los generales son solo para la clase hija, los atributos en base son los que enviaremos al padre 
        }
        public void esconderse()
        {
            Console.WriteLine("Este animal está escondiendose");
        }
    }

    class Carnivoro : Animal //clase que hereda clase hija : clase padre
    //se hereda TODO lo publico y protegido
    {
        public string comida;
        public Carnivoro(string a, string com, double b, double c)
            :base(a,b,c) //la base es para enviar parametros de la clase hija a la clase padre
        {
            comida = com; //los generales son solo para la clase hija, los atributos en base son los que enviaremos al padre 
        }
        public void cazar()
        {
            Console.WriteLine("Este animal está cazado");
        }
    }


    }
