using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace examen_parcial__1_
{
    public class Pedidos
    {
        public int Numero { get; set; }
        public DateOnly Fecha { get; set; }
        public Cliente ClientePedido { get; set; } = new Cliente();
        public Pedidos() { }
        public virtual void MostrarInformacionPedido()
        {
            Console.WriteLine($"Numero pedido: {Numero}");
            Console.WriteLine($"Fecha del pedido: {Fecha}");
            ClientePedido.MostrarInformacionCliente(ClientePedido);
        }
        public int NumPedido(List<Pedidos> listaPedidos)
        {
            Console.Write("> Ingrese el numero de pedido: ");
            int numeroPedido = LlenarNumeroEntero();
            foreach (var pedido in listaPedidos)
            {
                if (numeroPedido == pedido.Numero)
                {
                    Console.WriteLine("[!] Ya hay una reservacion con este numero...");
                    return -1;
                }
            }
            return numeroPedido;
        }
        public virtual void RegistrarPedido(int numeroPedido, List<Cliente> listaClientes)
        {
            
            if (numeroPedido >= 0)
            {
                Console.WriteLine("Ingrese la fecha de pedido...");
                Console.Write("Ingrese el dia: ");
                int dia = LlenarNumeroEntero();
                Console.Write("Ingrese el mes: ");
                int mes = LlenarNumeroEntero();
                Console.Write("Ingrese el año: ");
                int año = LlenarNumeroEntero();
                Cliente clienteActual = ClientePedido.BuscarCliente(listaClientes);
                if (clienteActual != null)
                {
                    this.ClientePedido = clienteActual;
                }
                else 
                {
                    Console.WriteLine("[!] No se ha encontrado al cliente");
                    Console.WriteLine("No se ha registrado el pedido...");
                    Console.WriteLine("Regresando al menu...");
                    return;
                }

                this.Numero = numeroPedido;
                this.Fecha = new(año, mes, dia);
                this.ClientePedido = clienteActual;
                Console.WriteLine("Cliente Registrado con Exito");
            }
            else 
            {
                Console.WriteLine("Regresando al menu...");
                return;
            }
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
                        if (numeroEntero < 0)
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
                    Console.WriteLine("[!] Error desconocido... " + ex + "\n");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroEntero;
        }
        public string LlenarString()
        {
            string cadena = string.Empty;
            bool valido = false;
            while (!valido)
            {
                cadena = Console.ReadLine();
                if (!string.IsNullOrEmpty(cadena))
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("[!] No puede ingresar datos vacíos...");
                    Console.Write("Intente de nuevo: ");
                }
            }
            return cadena;
        }


    }
}
