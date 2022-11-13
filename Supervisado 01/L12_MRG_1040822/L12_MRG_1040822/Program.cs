using System;

namespace L12_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero;
            numero = new int[14];
            int suma = 0;
            int q = 0;
            double porciento = 0;

            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine("Ingrese un valor");
                numero[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 14; i++)
            {
                suma = suma + numero[i];
            }
            Console.WriteLine("La suma total de los valores es: " + suma);

            for (int i = 0; i < 14; i++)
            {
                if (numero[i] > 12)
                {
                    q++;
                }
            }
            Console.WriteLine("El total de valores que son mayores a 12 es: " + q);
            porciento = (Convert.ToDouble(q) / 14) * 100;
            Console.WriteLine("El porcentaje de valores que son mayores a 12 es: " + porciento + "%");
            Console.ReadKey();
        }
    }
}

