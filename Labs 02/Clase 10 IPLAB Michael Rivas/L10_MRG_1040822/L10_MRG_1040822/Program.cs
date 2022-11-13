using System;

namespace L10_MRG_1040822
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass;
            string user;
            int q = 0;
            bool usa;
                do
            {
                Console.WriteLine("Ingrese usuario");
                user=Console.ReadLine();
                Console.WriteLine("Ingrese sucontraseña");
                pass= Console.ReadLine();

                usa = Login(user, pass);
                if (usa==true)
                {
                    Console.WriteLine("Usuario y contraseña correcto, bienvenido papu");
                    q = 3;
                }
                else
                {
                    q++;
                    Console.WriteLine("Usuario y contraseña incorrecta,intente de nuevo");
                    Console.WriteLine("Numero de intentos utilizados: " + q);
                    Console.WriteLine("El numero de intentos maximo es 3");
                }

            } while (q<3);
            Console.ReadKey();
        }

        static bool Login(string username, string password)
        {
            if (username == "usuario1" && password == "asdasd")
            {
                return true;
            }
            else
                return false;

        }
    }
}

