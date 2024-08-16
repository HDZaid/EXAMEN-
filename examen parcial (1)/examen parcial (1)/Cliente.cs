using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public DateOnly Fecha { get; set; }
        public double Descuento { get; set; } 
        public Cliente() { }

        public Cliente(string nombre, string correo, string direccion)
        {
            this.Nombre = nombre;
            this.Correo = correo;   
            this.Direccion = direccion;
            this.Descuento = 0;
        }

        public virtual void RegistrarCliente()
        {
            string nombreCliente, correoCliente, direccionCliente;
            int dia, mes, año;
            Console.Write("Ingrese el nombre del cliente: ");
            nombreCliente = LlenarString();
            Console.Write("Ingrese el correo del cliente: ");
            correoCliente = LlenarString();
            Console.Write("Ingrese la direccion del cliente: ");
            direccionCliente = LlenarString();
            Console.WriteLine("Ingrese la fecha de registro...");
            Console.Write("Ingrese el dia: ");
            dia = LlenarNumeroEntero();
            Console.Write("Ingrese el mes: ");
            mes = LlenarNumeroEntero();
            Console.Write("Ingrese el año: ");
            año = LlenarNumeroEntero();
            this.Nombre = nombreCliente;
            this.Correo = correoCliente;
            this.Direccion = direccionCliente;
            this.Fecha = new(año, mes, dia);
            Console.WriteLine("[!] Cliente registrado con exito...");

        }
        public Cliente BuscarCliente(List<Cliente> listaClientes)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string clienteBuscar = Console.ReadLine();
            Cliente cliente = listaClientes.Find(c => c.Nombre.Equals(clienteBuscar));
            if (cliente != null)
            {
                return cliente;
            }
            else
            {
                Console.WriteLine("[!] Cliente no encontrado.");
                return null;
            }
        }
        public virtual void MostrarInformacionCliente(Cliente cliente) 
        {
            if (cliente != null)
            {
                Console.WriteLine($"Nombre del Cliente: {Nombre}");
                Console.WriteLine($"Correo: {Correo}");
                Console.WriteLine($"Direccion: {Direccion}");
                Console.WriteLine($"Fecha de Registro: {Fecha}");
            }
            else 
            {
                return;
            }
        }
        public virtual double CalcularDescuento() { 
            return Descuento;
        }
        public virtual void MostrarClientes(List<Cliente> listaClientes)
        {
            foreach (var cliente in listaClientes) 
            { 
                cliente.MostrarInformacionCliente(cliente);
            }
        }


        //Metodos de entrada usuario
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
