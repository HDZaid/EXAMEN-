using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    public class ClaseBase
    {
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public ClaseBase() { }

        public ClaseBase(string direccion, string nombre, string correo)
        {
            this.Direccion = direccion;
            this.Nombre = nombre;
            this.Correo = correo;
        }

        public virtual void AgregarCliente()
        {
            Console.WriteLine("INGRESE UNA DIRECCION");
            this.Direccion = Console.ReadLine();
            Console.WriteLine("INGRESE UN NUMBRE");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("INGRESE CORREO");
            this.Correo = Console.ReadLine();
        }
        public virtual void MostrarInformacionCliente() 
        {   
            Console.WriteLine($"EL NOMBRE ES: {Nombre}");
            Console.WriteLine($"LA DIRECCION ES: {Direccion}");
            Console.WriteLine($"EL CORREO ES: {Correo}");
        }
    }
}
