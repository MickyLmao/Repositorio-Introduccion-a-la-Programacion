using System;

namespace T6_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            int dia;
            Console.WriteLine("ingrese numero de mes nacimiento, 1~12");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de dia de nacimiento, 1~31");
            dia = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    //EN CASO DE NACER EN ENERO
                    if (dia < 20)
                    {
                        Console.WriteLine("Su signo zodiacal es Capricornio");
                    }
                    else if (dia > 31)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 19)
                    {
                        Console.WriteLine("Su signo zodiacal es Acuario");
                    }
                    break;

                case 2:
                    //EN CASO DE NACER EN FEBBRERO
                    if (dia < 19)
                    {
                        Console.WriteLine("Su signo zodiacal es Acuario");
                    }
                    else if (dia > 28)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 18)
                    {
                        Console.WriteLine("Su signo zodiacal es Piscis");
                    }
                    break;

                case 3:
                    //EN CASO DE NACER EN MARZO
                    if (dia < 21)
                    {
                        Console.WriteLine("Su signo zodiacal es Piscis");
                    }
                    else if (dia > 31)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 20)
                    {
                        Console.WriteLine("Su signo zodiacal es Aries");
                    }
                    break;

                case 4:
                    //EN CASO DE NACER EN ABRIL
                    if (dia < 20)
                    {
                        Console.WriteLine("Su signo zodiacal es Aries");
                    }
                    else if (dia > 30)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia>21)
                    {
                        Console.WriteLine("Su signo zodiacal es Tauro");
                    }
                    break;

                case 5:
                    //EN CASO DE NACER EN MAYO
                    if (dia < 21)
                    {
                        Console.WriteLine("Su signo zodiacal es Tauro");
                    }
                    else if (dia > 31)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 20)
                    {
                        Console.WriteLine("Su signo zodiacal es Géminis");
                    }
                    break;

                case 6:
                    //EN CASO DE NACER JUNIO
                    if (dia < 21)
                    {
                        Console.WriteLine("Su signo zodiacal es Géminis");
                    }
                    else if (dia > 30)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 20)
                    {
                        Console.WriteLine("Su signo zodiacal es Cancer");
                    }
                    break;

                 case 7:
                    //EN CASO DE NACER EN JULIO
                    if (dia < 23)
                    {
                        Console.WriteLine("Su signo zodiacal es Cancer");
                    }
                    else if (dia > 31)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 22)
                    {
                        Console.WriteLine("Su signo zodiacal es Leo");
                    }
                    break;

                case 8:
                    //EN CASO DE NACER EN AGOSTO
                    if (dia < 23)
                    {
                        Console.WriteLine("Su signo zodiacal es Leo");
                    }
                    else if (dia > 31)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 22)
                    {
                        Console.WriteLine("Su signo zodical es Virgo");
                    }
                    break;

                case 9:
                    //EN CASO DE NACER EN SEPTIEMBRE
                    if (dia < 23)
                    {
                        Console.WriteLine("Su signo zodiacal es Virgo");
                    }
                    else if (dia > 30)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 22)
                    {
                        Console.WriteLine("Su signo zodiacal es Libra");
                    }
                    break;

                case 10:
                    //EN CASO DE NACER EN OCTUBRE
                    if (dia < 23)
                    {
                        Console.WriteLine("Su signo zodiacal es libra");
                    }
                    else if (dia > 31)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 22)
                    {
                        Console.WriteLine("Su signo zodiacal es Escorpio");
                    }
                    break;

                case 11:
                    //EN CASO DE NACER EN NOVIEMBRE
                    if (dia < 22)
                    {
                        Console.WriteLine("Su signo zodiacal es Escorpio");
                    }
                    else if (dia > 30)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 21)
                    {
                        Console.WriteLine("Su signo zodiacal es Sagitario");
                    }
                    break;

                case 12:
                    //EN CASO DE NACER EN DICIEMBRE
                    if (dia < 22)
                    {
                        Console.WriteLine("Su signo zodiacal es Sagitario");
                    }
                    else if (dia > 31)
                    {
                        Console.WriteLine("ERROR: SU NUMERO DE DIA NO ES VALIDO");
                    }
                    else if (dia > 21)
                    {
                        Console.WriteLine("Su signo zodiacal es Capricornio");
                    }
                    break;

                default:
                    if (mes>12)
                    {
                       Console.WriteLine("ERROR: SU NUMERO DE MES NO ES VALIDO");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}

