using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CTOR = constructor
//2 x [ctrl + R]


namespace examen_parcial__1_
{
    internal class Menus
    {

        public Menus()
        {
            
        }
        public void MenuPrincipal()
        {
            Console.WriteLine("[ 1 ] opcion  ");
            Console.WriteLine("[ 2 ] opcion  ");
            Console.WriteLine("[ 3 ] opcion  ");
            Console.WriteLine("[ 4 ] opcion  ");
        }

        public void MenuSecundario()
        {
            Console.WriteLine("[ 1 ] opcion");
            Console.WriteLine("[ 2 ] opcion");
            Console.WriteLine("[ 3 ] opcion");
        }

        public int LlenarNumeroEntero()
        {
            int numeroEntero = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    while (numeroEntero <= 0)
                    {
                        numeroEntero = Convert.ToInt32(Console.ReadLine());
                        if (numeroEntero <= 0)
                        {
                            Console.Write("No puede ingresar numeros negativos...\nIntente de nuevo: ");
                        }
                        valido = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("> Intente de nuevo: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[!] Error desconocido... " + ex);
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroEntero;
        }


    }
}
