using System;

namespace L1_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Holis mundo");
            Console.WriteLine("soy " + Nombre);

            /* El writeline escribe el texto con la separacion de parrafos que nosotros escribamos, mientras que write escribe junto  */

            Console.Write("Holis mundo ");
            Console.Write("soy " + Nombre);
            Console.ReadKey();
        }
    }
}

