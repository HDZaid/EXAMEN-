using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_parcial__1_
{
    public class Pedidos 
    {
        public int NumeroUnico { get; set; }
        public string Fecha { get; set; } //NO RECUERDO LA SINTAXIS DE LA FECHA 
        public ClaseBase Cliente { get; set; } = new ClaseBase();

        public Pedidos()
        {
            


        }
        public  void mostrarInformacionPedidos()
        {
            Console.WriteLine($"Numero del Pedido: {NumeroUnico}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"-----------Informacion Cliente----------- ");
            Console.WriteLine($"Nombre Cliente: {Cliente.Nombre}");
            Console.WriteLine($"Nombre Cliente: {Cliente.Direccion}");
            Console.WriteLine($"Nombre Cliente: {Cliente.Correo}");
            Console.WriteLine($"----------------------------------------- ");
        }

        public  void AgregarPedidos(List<ClaseBase> listaClientes, string nombreCliente)
        {
            Console.WriteLine($"Ingrese un NUMERO ");
            this.NumeroUnico = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ingrese FECHA ");
            this.Fecha = Console.ReadLine();
            foreach (ClaseBase cliente in listaClientes)
            {
                if (cliente is ClienteEstandar clienteEstandar && clienteEstandar.Nombre == nombreCliente)
                {
                    Cliente = clienteEstandar;
                    break;
                }
                else if (cliente is ClientePremium clientePremium && clientePremium.Nombre == nombreCliente)
                {
                    Cliente = clientePremium;
                    break;
                }
            }
        }
    }
}
