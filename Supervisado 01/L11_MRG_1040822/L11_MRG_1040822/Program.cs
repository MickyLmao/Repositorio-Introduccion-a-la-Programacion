using System;

namespace L11_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int Sum = 0;
            int sumapar = 0;
            int sumaimpar = 0;
            Console.WriteLine("Ingrese la cantidad de datos que quiere ingresar");
            N = int.Parse(Console.ReadLine());
            int[] vector;
            vector = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Ingrese el dato No. " + (i));
                vector[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("El valor ingresado para la casilla " + (i) + " = " + vector[i]);
            }
            for (int i = 0; i < N; i++)
            {
                Sum = Sum + vector[i];
            }
            Console.WriteLine("La suma total de los valores del vector es: " + Sum);
            Console.WriteLine("La longitud del arreglo es: " + N);
            for (int i = 0; i < N; i++)
            {
                if ((i) % 2 == 0)
                {
                    sumapar = sumapar + vector[i];
                }
                else
                {
                    sumaimpar = sumaimpar + vector[i];
                }
            }
            Console.WriteLine("La suma de los valores en posiciones pares es: " + sumapar);
            Console.WriteLine("La suma de los valores en ´posiciones impar es: " + sumaimpar);
            Console.ReadKey();
        }
    }
}

