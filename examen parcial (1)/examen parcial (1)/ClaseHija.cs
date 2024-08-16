using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    internal class ClaseHija: ClaseBase
    {
        public int MyProperty { get; set; }
        

        public ClaseHija()
        {
            
        }
        public ClaseHija(int id, string nombre,int myalgo)
            :base(id, nombre) 
        {
            this.MyProperty = id;
            //
            //
        }

        public override void Agregar()
        {
            base.Agregar();
            Console.WriteLine("agregue otra cosa");
            this.MyProperty = Convert.ToInt32(Console.ReadLine());
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"MUESTRE OTRA COSA:{MyProperty}");
        }



    }
}
