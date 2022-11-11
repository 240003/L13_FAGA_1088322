using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13_FAGA_1088322
{
    class PruebaVector
    {
        private int[] edad;
        private string[] nombres;

        public void Cargar()
        {
            nombres = new string[5];
            edad = new int[5];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre de la persona: ");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese la edad de la persona: ");
                edad[f] = int.Parse(Console.ReadLine());
            }
        }
        public void MayoresEdad()
        {
            Console.WriteLine("Personas mayores de edad");
            for (int f = 0; f < nombres.Length; f++)
            {
                if (edad[f] >= 18)
                {
                    Console.WriteLine(nombres[f]);
                }
            }

        }
        static void Main(string[] args)
        {
            PruebaVector p = new PruebaVector();
            p.Cargar();
            p.MayoresEdad();
            Console.ReadKey();
        }
    }
}