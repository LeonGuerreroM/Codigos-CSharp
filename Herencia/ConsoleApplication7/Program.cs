using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using herenciaAnimal;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Herbivoro jirafa = new Herbivoro("cafe","wiskas",18.5,100.5);
            Carnivoro leon = new Carnivoro("gente","naranja",20.5,60.9);
            //Animal obj = new Animal();

            //jirafa.color = "Café";
            Console.WriteLine("Color jirafa: {0}",jirafa.color);
            jirafa.dormir();
            jirafa.esconderse();

            //leon.peso = 12.7;
            Console.WriteLine("\nPeso leon: {0}", leon.peso);
            leon.correr();
            leon.cazar();

            //Console.WriteLine("\nColor animal: {0}", );


            Console.ReadKey();
        }
    }
}
