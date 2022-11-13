using System;

namespace L11_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] calc;
            calc = new double[4];

            double[] calc2;
            calc2 = new double[4];

            int q = 0;
            int k = 0;
            double ap = 0;
            double ap2 = 0;
            double rep = 0;
            double rep2 = 0;
            double ap3 = 0;
            double rep3 = 0;
            double prom = 0;
            double prom2 = 0;
            double prom3 = 0;
            double tot = 0;
            double tot2 = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int cont = 0;
            int cont2 = 0;


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese la nota del estudiante " + (i + 1) + " en la seccion 1");
                calc[i]=double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese la nota del estudiante " + (i + 1) + " en la seccion 2");
                calc2[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                if (calc[i] >= 65)
                {
                    q++;
                }

                if (calc2[i]>=65)
                {
                    k++;
                }
            }
            ap = Convert.ToDouble(q) / 4 * 100;
            Console.WriteLine("El porcentaje de alumnos aprovados en la seccion 1 es de " + ap + "%");

            ap2 = Convert.ToDouble(k) / 4 * 100;
            Console.WriteLine("El porcentaje de alumnos aprovados en la seccion 2 es de " + ap2 + "%");

            rep = Convert.ToDouble(100-ap);
            Console.WriteLine("El porcentaje de alumnos reprovados en la seccion 1 es de " + rep + "%");

            rep2 = Convert.ToDouble(100 - ap2);
            Console.WriteLine("El porcentaje de alumnos reprovados en la seccion 2 es de " + rep2 + "%");

            ap3 = Convert.ToDouble(ap+ap2) / 2;
            Console.WriteLine("El porcentaje de alumnos aprovados en ambas secciones es de " + ap3 + "%");

            rep3 = Convert.ToDouble(100 - ap3);
            Console.WriteLine("El porcentaje de alumnos reprovados en ambas secciones es de " + rep3 + "%");

            for (int i = 0; i < 4; i++)
            {
                tot = tot + calc[i];
            }
            prom = tot / 4;
            Console.WriteLine("El promedio de las notas en la seccion 1 es de " + prom);

            for (int i = 0; i < 4; i++)
            {
                tot2 = tot2 + calc2[i];
            }
            prom2 = tot2 / 4;
            Console.WriteLine("El promedio de las notas en la seccion 2 es de " + prom2);

            prom3 = (prom + prom2) / 2;
            Console.WriteLine("El promedio de las notas en ambas secciones es de " + prom3);

            for (int i = 0; i < 4; i++)
            {
                if (calc[i] > 90)
                {
                    a++;
                }

                if (calc[i] < 75)
                {
                    b++;
                }

                if (calc2[i] > 90)
                {
                    c++;
                }

                if (calc2[i] < 75)
                {
                    d++;
                }
            }
            cont = (a + c);
            Console.WriteLine("La cantidad de estudiantes con un promedio por arriba de 90 es de " + cont);

            cont2 = (b + d);
            Console.WriteLine("La cantidad de estudiantes con un promedio por abajo de 75 es de " + cont2);
            
            Console.ReadKey();
        }
    }
}

