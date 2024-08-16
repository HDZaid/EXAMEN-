using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    public class Interfaz
    {
        public int MyProperty { get; set; }
        public string Algo { get; set; }
        public bool XD { get; set; }
        public ClaseBase Clase { get; set; } = new ClaseBase();

        public Interfaz()
        {
            


        }
        public virtual void mostrarInformacion()
        {
            Console.WriteLine($"Numero: {MyProperty}");
            Console.WriteLine($"Nombre: {Algo}");
            Console.WriteLine($"bool: {XD}");
        }

        public virtual void AgregarObjeto()
        {
            Console.WriteLine($"Ingrese Nombre ");
            this.MyProperty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ingrese Numero ");
            this.Algo = Console.ReadLine();
            this.XD = true;
            
        }


    }
}
