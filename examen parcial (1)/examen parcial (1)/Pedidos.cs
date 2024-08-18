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
        public double Total { get; set; }
        public Pedidos() { }
        public virtual void MostrarInformacionPedido(Pedidos pedido)
        {
            if (pedido != null) {
                Console.WriteLine($"Numero pedido: {pedido.Numero}");
                Console.WriteLine($"Fecha del pedido: {pedido.Fecha}");
                Console.WriteLine($"Total del pedido: {pedido.Total}");
                ClientePedido.MostrarInformacionCliente(pedido.ClientePedido);
            }
            else 
            {
                Console.WriteLine("Regresando al menu...");
                return;
            }
        }
        public void MostrarPedidos(List<Pedidos> listaPedidos) 
        {
            foreach (var pedido in listaPedidos)
            {
                MostrarInformacionPedido(pedido);
            }
        }
        public Pedidos BuscarPedido(List<Pedidos> listaPedidos)
        {
            Console.Write("Ingrese el numero del pedido: ");
            int clienteBuscar = LlenarNumeroEntero();
            Pedidos pedido = listaPedidos.Find(p => p.Numero.Equals(clienteBuscar));
            if (pedido != null)
            {
                return pedido;
            }
            else
            {
                Console.WriteLine("[!] Pedido no encontrado.");
                return null;
            }
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
                Console.Write("Ingrese el monto: ");
                double montoCliente = LlenarNumeroDouble();
                Console.WriteLine("Pedido registrado con Exito");
                this.Total = clienteActual.CalcularDescuento(clienteActual, montoCliente);
            }
            else 
            {
                Console.WriteLine("Regresando al menu...");
                return;
            }
        }
        //Metodos de introduccion de datos de usuario
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
        public double LlenarNumeroDouble()
        {
            double numeroDouble = 0;
            bool valido = false;
            while (!valido)
            {
                try
                {
                    numeroDouble = Convert.ToDouble(Console.ReadLine());
                    valido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("[!] Error no puede ingresar letras...");
                    Console.Write("> Intente de nuevo: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("[!] Error desconocido... ");
                    Console.Write("> Intente de nuevo: ");
                }
            }
            return numeroDouble;
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
