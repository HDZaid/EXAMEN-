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
            :base(nombre, correo, direccion)
        {
            this.Descuento = 0.15;
        }
        public ClientePremium() { }
        public override void RegistrarCliente()
        {
            Console.WriteLine("\t\t> Registrar un nuevo cliente premium\t\t");
            base.RegistrarCliente();
        }
        public override void MostrarInformacionCliente(Cliente cliente)
        {
            base.MostrarInformacionCliente(cliente);
            Console.WriteLine($"Cliente Premium Descuento: {(Descuento*100)}%");
        }
        public override double CalcularDescuento()
        {
            return Descuento;
        }



    }
}
