using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    public class ClienteEstandar: ClaseBase
    {
        public string FechaDeRegistro { get; set; } // no recuerdo la sintaxis de fechaa :c
        

        public ClienteEstandar()
        {
            
        }
        public ClienteEstandar(string direccion, string nombre,string correo,string fecha)
            :base(direccion, nombre,correo) 
        {
            this.FechaDeRegistro =fecha ;
            //
            //
        }

        public override void AgregarCliente()
        {
            base.AgregarCliente();
            Console.WriteLine("INGRESE FECHA DE REGISTRO ");
            this.FechaDeRegistro = Console.ReadLine();
        }

        public override void MostrarInformacionCliente()
        {
            base.MostrarInformacionCliente();
            Console.WriteLine($"FECHA DE REGISTRO:{FechaDeRegistro}");
        }



    }
}
