using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    public class ClientePremium : Cliente
    {
        public ClientePremium(string nombre, string correo, string direccion)
            : base(nombre, correo, direccion)
        {
            this.Descuento = 0.15;
        }
        public ClientePremium() {
            this.Descuento = 0.15;
        }
        public override void RegistrarCliente()
        {
            Console.WriteLine("\t\t> Registrar un nuevo cliente premium <");
            base.RegistrarCliente();
        }
        public override void MostrarInformacionCliente(Cliente clienteActual)
        {
            base.MostrarInformacionCliente(clienteActual);
            Console.WriteLine($"Cliente Premium Descuento: {(clienteActual.Descuento*100)}%");
        }
        public override double CalcularDescuento(Cliente clienteActual, double totalCuenta)
        {
            Console.WriteLine($"[!] Cliente Premium descuento del: {(clienteActual.Descuento*100)}%");
            Console.WriteLine($"El total de la cuenta es: Q"+ (totalCuenta - (totalCuenta * clienteActual.Descuento)));
            return totalCuenta - (totalCuenta * clienteActual.Descuento);
        }
    }
}
