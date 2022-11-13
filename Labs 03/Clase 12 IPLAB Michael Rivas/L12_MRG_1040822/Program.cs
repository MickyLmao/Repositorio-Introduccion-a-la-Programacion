using System;

namespace L12_MRG_1040822
{
    internal class Program
    {

            static void Main(string[] args)
            {
            double[,] datos = new double[4, 5];
            double[,] datosb = new double[4, 5];
            double[,] resultado = new double[4, 5];
            double suma = 0;



            double promedio1 = 0;


            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 5; q++)
                {
                    Console.WriteLine("Ingrese un valor para la primer matriz");
                    datos[i, q] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 5; q++)
                {
                    suma = suma + datos[i, q];
                }
            }
            Console.WriteLine("El resultado de los valores de la matriz 1 es: " + suma);
            promedio1 = suma/ 20;
   
            Console.WriteLine("El promedio de la matriz 1 es: " + promedio1);
  

            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 5; q++)
                {
                    Console.WriteLine("Ingrese un valor para la segunda matriz");
                    datosb[i, q] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 5; q++)
                {
                    resultado[i, q] = datos[i, q] + datosb[i, q];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int q = 0; q < 5; q++)
                {
                    Console.Write(resultado[i, q] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        
    }
}

