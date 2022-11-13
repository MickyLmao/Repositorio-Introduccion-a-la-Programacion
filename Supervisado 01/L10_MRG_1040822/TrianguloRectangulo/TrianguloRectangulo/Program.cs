using System;

namespace TrianguloRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lab10");
            Console.WriteLine("ingrese el cateto A");
            double catetoingresado = double.Parse(Console.ReadLine());
            Console.WriteLine("Iingrese angulo opuesto A en radianes");
            double angulopingresadoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Iingrese altura");
            double alturaingresada = double.Parse(Console.ReadLine());
            Console.WriteLine("Iingrese largo");
            double largoingresado = double.Parse(Console.ReadLine());

            double catetobcalculado = 0;
            double catetoccalculado = 0;
            double angulopbcalculado = 0;
            double areacalculada = 0;

            triangulo objtcirculo = new triangulo(catetoingresado, angulopingresadoA, alturaingresada, largoingresado);

            objtcirculo.Calculargeometria(ref catetobcalculado, ref catetoccalculado, ref angulopbcalculado, ref areacalculada);

            Console.WriteLine("catetob " + catetobcalculado);
            Console.WriteLine("catetoc " + catetoccalculado);
            Console.WriteLine("angulo opuesto b " + angulopbcalculado);
            Console.WriteLine("areacalculada " + areacalculada);

            Console.ReadKey();

        }
    }
    class triangulo
    {
        private double catetoA, anguloA, altura, largo;
        public triangulo(double Bases, double AnguloA, double Altura, double Largo)
        {
            catetoA = Bases;
            anguloA = AnguloA;
            altura = Altura;
            largo = Largo;
        }

        private double obtenercatetoB()
        {
            double CatetoB = (catetoA) / (Math.Tan(anguloA));
            return CatetoB;

        }
        private double obtenercatetoC()
        {
            double CatetoC = ((catetoA) / Math.Sin(anguloA));
            return CatetoC;
        }
        private double obtenerangulopuestob()
        {
            double AngulopB = 180 - anguloA - 90;
            return AngulopB;
        }
        private double obtenerarea()
        {
            double Area = (largo * altura) / 2;
            return Area;
        }
        public void Calculargeometria(ref double uncatetoB, ref double uncatetoC, ref double unangulopB, ref double unarea)
        {

            uncatetoB = obtenercatetoB();
            uncatetoC = obtenercatetoC();
            unangulopB = obtenerangulopuestob();
            unarea = obtenerarea();
        }
    }

}