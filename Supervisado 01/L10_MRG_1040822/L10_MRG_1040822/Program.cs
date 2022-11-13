using System;

namespace L10_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lab 10 por Michael rivas");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese radio del circulo");

            double radioIngresado = double.Parse(Console.ReadLine());
            double perimetroCalculado = 0;
            double areaCalculada = 0;
            double volumenCalculado = 0;

            // Objeto de tipo Circulo:
            Circulo objCirculo = new Circulo(radioIngresado);

            //Guardar los calculos
            objCirculo.CalcularGeometria(ref perimetroCalculado, ref areaCalculada, ref volumenCalculado);

            //mostrar resultados
            Console.WriteLine("Perimetro: " + perimetroCalculado);
            Console.WriteLine("Area: " + areaCalculada);
            Console.WriteLine("Volumen " + volumenCalculado);

            Console.ReadKey();
        }
    }
    class Circulo
    {
        private double radio;

        public Circulo (double Radio)
        {
            radio = Radio;
        }

        private double ObtenerPerimetro()
        {
            double perimetro = 2 * Math.PI * radio;
            return perimetro;
        }

        private double ObtenerArea()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }

        private double ObtenerVolumen()
        {
            double volumen = (4 * Math.PI * Math.Pow(radio, 3)) / 3;
            return volumen;
        }

        public void CalcularGeometria(ref double unPerimentro, ref double unArea, ref double unVolumen)
        {
            unPerimentro = ObtenerPerimetro();
            unArea = ObtenerArea();
            unVolumen = ObtenerVolumen();
        }
    }
}

