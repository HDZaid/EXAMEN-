using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    public class ClaseBase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public ClaseBase() { }

        public ClaseBase(int id, string nombre)
        {
            this.ID = id;
            this.Nombre = nombre;   
        }

        public virtual void Agregar()
        {
            Console.WriteLine("INGRESE UN NUMERO");
            this.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("INGRESE UN NUMBRE");
            this.Nombre = Console.ReadLine();
        }
        public virtual void MostrarInformacion() 
        {
            Console.WriteLine($"ID ES: {ID}");
            Console.WriteLine($"EL NOMBRE ES: {Nombre}");
        }
    }
}
