using System;

namespace T1_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");

            Console.WriteLine("Ingresar nombre: ");
            String sNombre = Console.ReadLine();

            Console.WriteLine("Ingrese edad: ");
            String sEdad = Console.ReadLine();

            Console.WriteLine("Ingrese carrera: ");
            String sCarrera = Console.ReadLine();

            Console.WriteLine("Ingrese Carne: ");
            String sCarne = Console.ReadLine();

            Console.WriteLine("Nombre: " + sNombre);
            Console.WriteLine("Edad: " + sEdad);
            Console.WriteLine("Carrera: " + sCarrera);
            Console.WriteLine("Carne: " + sCarne);

            Console.Write("Soy " + sNombre);
            Console.Write(" tengo " + sEdad);
            Console.Write(" aNnos y estudio la carrera de " + sCarrera);
            Console.Write(" mi numero de carne es " + sCarne);

            Console.ReadKey();

        }
    }
}