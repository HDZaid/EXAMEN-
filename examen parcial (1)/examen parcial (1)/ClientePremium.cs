using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    internal class ClientePremium: ClaseBase
    {
        public int Descuento { get; set; }

        public ClientePremium()
        {
            
        }
        public ClientePremium(string direccion, string nombre, string correo, int descuento)
            : base(direccion, nombre, correo)
        {
            this.Descuento = descuento;
            //
            //
        }

        public  override void AgregarCliente()
        {
            base.AgregarCliente();
            Console.WriteLine("INGRESE DESCUENTO");
            this.Descuento = Convert.ToInt32(Console.ReadLine());
        }

        public override void MostrarInformacionCliente()
        {
            base.MostrarInformacionCliente();
            Console.WriteLine($"EL DESCUENTO ES DE:{Descuento}");
        }

    }
}
